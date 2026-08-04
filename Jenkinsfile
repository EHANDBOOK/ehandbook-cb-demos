final String LABEL = 'Linux_67'
library identifier: 'ehandbook-jenkins-library@13.1.16'

final String BITBUCKET_CREDENTIALS = '73ab8e6b-2e5b-409f-928c-c70f3ecd0094'
final String GITHUB_ACTIONS_DISPATCH_TOKEN_CREDENTIALS = 'github-actions-dispatch-token'

final String FOSSLENSE_PRODUCT_ID = '1661'
final String SOURCES_URI = 'https://bitbucket.etas-dev.com/scm/ehb/ehandbook-cb-demos.git'

final String GIT_SYNC_FOLDER = '.'

properties(jenkins.createBasicBuildProperties() + 
	parameters([
		booleanParam(name: 'publishToGitHub', description: "Publish the CB Demos to GitHub.com (https://github.com/EHANDBOOK/ehandbook-cb-demos)."),
		booleanParam(name: 'triggerGitHubCloudServiceWorkflow', defaultValue: false, description: "Trigger GitHub workflow 'Container-Build-Cloud-Service-demo.yml' after sync."),
		string(name: 'githubRef', defaultValue: 'main', description: "Git ref (branch or tag) used for GitHub workflow dispatch."),
		string(name: 'demoFolder', defaultValue: 'Demo_EHBCB_DirBased_AUTOSAR_SL_FlexECU/Input', description: "workflow_dispatch input: demo_folder"),
		string(name: 'storageType', defaultValue: 'GIT', description: "workflow_dispatch input: storage_type"),
		string(name: 'storageUrl', defaultValue: 'https://github.com/EHANDBOOK/ehandbook-cb-demos.git', description: "workflow_dispatch input: storage_url"),
		string(name: 'configFile', defaultValue: '', description: "workflow_dispatch input: config_File (optional)")
	])
)

timestamps {
	node(LABEL) {

		stage('Checkout') {
			// Clean the checkout folder before cloning
			deleteDir()
			dir(GIT_SYNC_FOLDER) {
				checkout scm

				// Remove files not needed for GitHub
				sh 'rm .mailmap Jenkinsfile'
			}
		}

		stage('Open Source Scan') {
			if (buildEnv.isMasterBranch()){
				fosslens.triggerScan(FOSSLENSE_PRODUCT_ID, SOURCES_URI)
			}
		}

		stage('Preflight: GitHub workflow validation') {
			dir(GIT_SYNC_FOLDER) {
				sh '''
					set -euo pipefail

					# Skip gracefully if no workflow files are present.
					if [ ! -d .github/workflows ]; then
						echo "No .github/workflows directory found. Skipping preflight checks."
						exit 0
					fi

					# Build a stable workflow file list for linters/checks.
					find .github/workflows -maxdepth 1 -type f \( -name '*.yml' -o -name '*.yaml' \) | sort > workflow-files.txt
					if [ ! -s workflow-files.txt ]; then
						echo "No workflow YAML files found. Skipping preflight checks."
						exit 0
					fi

					# 1) Semantic GitHub Actions validation with actionlint
					docker pull rhysd/actionlint:latest
					docker run --rm \\
						-v "$PWD:/repo" \\
						-w /repo \\
						rhysd/actionlint:latest \\
						-color \\
						-oneline \\
						$(cat workflow-files.txt) 2>&1 | tee actionlint-report.txt

					# 2) Targeted sanity check for dispatch workflow and required inputs
					workflow_file=".github/workflows/Container-Build-Cloud-Service-demo.yml"
					if [ ! -f "$workflow_file" ]; then
						echo "Expected workflow file not found: $workflow_file" >&2
						exit 1
					fi

					for required_key in workflow_dispatch demo_folder storage_type storage_url config_File; do
						if ! grep -q "$required_key" "$workflow_file"; then
							echo "Missing required workflow key '$required_key' in $workflow_file" >&2
							exit 1
						fi
					done
					echo "Dispatch workflow key checks passed."
				'''

				archiveArtifacts artifacts: 'actionlint-report.txt,workflow-files.txt', allowEmptyArchive: true
			}
		}

		stage('zizmor (GitHub Actions security scan)') {
			dir(GIT_SYNC_FOLDER) {
				sh '''
					set -e

					# Skip gracefully when no GitHub workflow/action files are present
					if [ ! -d .github/workflows ] && [ ! -f action.yml ] && [ ! -f .github/dependabot.yml ]; then
						echo "No GitHub Actions inputs found. Skipping zizmor."
						exit 0
					fi

					docker pull ghcr.io/zizmorcore/zizmor:latest

					# Offline mode avoids GitHub API token requirements
					docker run --rm \
						-v "$PWD:/work" \
						-w /work \
						ghcr.io/zizmorcore/zizmor:latest \
						. \
						--collect workflows \
						--offline \
						--format sarif \
						--no-progress \
						> zizmor.sarif
				'''

				archiveArtifacts artifacts: 'zizmor.sarif', allowEmptyArchive: true
			}
		}

		if (params.publishToGitHub) {
			stage('Publish to GitHub.com') {
				git.publishToGitHub(GIT_SYNC_FOLDER, 'EHANDBOOK', 'ehandbook-cb-demos', "Publish EHANDBOOK CB Demos to GitHub.com", false)
			}
		}

		if (params.triggerGitHubCloudServiceWorkflow) {
			stage('Trigger GitHub Cloud Service workflow') {
				dir(GIT_SYNC_FOLDER) {
					withCredentials([string(credentialsId: GITHUB_ACTIONS_DISPATCH_TOKEN_CREDENTIALS, variable: 'GH_TOKEN')]) {
						sh '''
							set -euo pipefail

							REPO="EHANDBOOK/ehandbook-cb-demos"
							WORKFLOW_FILE="Container-Build-Cloud-Service-demo.yml"

							dispatch_time=$(date -u +%Y-%m-%dT%H:%M:%SZ)
							echo "Dispatching workflow at ${dispatch_time}"

							payload=$(jq -n \\
								--arg ref "${githubRef}" \\
								--arg demo_folder "${demoFolder}" \\
								--arg storage_type "${storageType}" \\
								--arg storage_url "${storageUrl}" \\
								--arg config_File "${configFile}" \\
								'{
									ref: $ref,
									inputs: {
										demo_folder: $demo_folder,
										storage_type: $storage_type,
										storage_url: $storage_url,
										config_File: $config_File
									}
								}')

							echo "Dispatch payload:" 
							echo "$payload"

							http_status=$(curl -sS -o /tmp/gh-dispatch-response.txt -w "%{http_code}" \\
								-X POST "https://api.github.com/repos/${REPO}/actions/workflows/${WORKFLOW_FILE}/dispatches" \\
								-H "Authorization: Bearer ${GH_TOKEN}" \\
								-H "Accept: application/vnd.github+json" \\
								-H "X-GitHub-Api-Version: 2022-11-28" \\
								-d "$payload")

							if [ "$http_status" -ne 204 ]; then
								echo "Failed to dispatch workflow. HTTP ${http_status}" >&2
								cat /tmp/gh-dispatch-response.txt >&2 || true
								exit 1
							fi

							echo "Workflow dispatched. Resolving run ID..."

							run_id=""
							attempt=0
							while [ -z "$run_id" ] && [ "$attempt" -lt 20 ]; do
								attempt=$((attempt+1))
								sleep 10

								response=$(curl -sS \\
									-H "Authorization: Bearer ${GH_TOKEN}" \\
									-H "Accept: application/vnd.github+json" \\
									-H "X-GitHub-Api-Version: 2022-11-28" \\
									"https://api.github.com/repos/${REPO}/actions/workflows/${WORKFLOW_FILE}/runs?event=workflow_dispatch&per_page=50")

								run_id=$(echo "$response" | jq -r --arg dispatch_time "$dispatch_time" '.workflow_runs[] | select(.created_at >= $dispatch_time) | .id' | head -n1)
							done

							if [ -z "$run_id" ]; then
								echo "Unable to identify dispatched workflow run ID." >&2
								exit 1
							fi

							echo "Dispatched run ID: ${run_id}"
							echo "Run URL: https://github.com/${REPO}/actions/runs/${run_id}"

							status="queued"
							conclusion=""
							attempt=0
							while [ "$attempt" -lt 180 ]; do
								attempt=$((attempt+1))
								sleep 20

								run_response=$(curl -sS \\
									-H "Authorization: Bearer ${GH_TOKEN}" \\
									-H "Accept: application/vnd.github+json" \\
									-H "X-GitHub-Api-Version: 2022-11-28" \\
									"https://api.github.com/repos/${REPO}/actions/runs/${run_id}")

								status=$(echo "$run_response" | jq -r '.status')
								conclusion=$(echo "$run_response" | jq -r '.conclusion // empty')
								echo "GitHub run status: ${status} conclusion: ${conclusion:-n/a}"

								if [ "$status" = "completed" ]; then
									break
								fi
							done

							if [ "$status" != "completed" ]; then
								echo "Timed out waiting for GitHub workflow run completion." >&2
								exit 1
							fi

							if [ "$conclusion" != "success" ]; then
								echo "GitHub workflow completed with conclusion: ${conclusion}" >&2
								exit 1
							fi

							echo "GitHub workflow completed successfully."
						'''
					}
				}
			}
		}
	}
}