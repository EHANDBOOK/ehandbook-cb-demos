final String LABEL = 'Linux_67'
library identifier: 'ehandbook-jenkins-library@13.1.16'

final String BITBUCKET_CREDENTIALS = '73ab8e6b-2e5b-409f-928c-c70f3ecd0094'
final String GITHUB_ACTIONS_DISPATCH_TOKEN_CREDENTIALS = 'github-actions-dispatch-token'
final String LOCAL_WORKFLOW_SECRETS_CREDENTIALS = 'github-workflow-local-secrets-env'

final String FOSSLENSE_PRODUCT_ID = '1661'
final String SOURCES_URI = 'https://bitbucket.etas-dev.com/scm/ehb/ehandbook-cb-demos.git'

final String GIT_SYNC_FOLDER = '.'

properties(jenkins.createBasicBuildProperties() + 
	parameters([
		booleanParam(name: 'publishToGitHub', description: "Publish the CB Demos to GitHub.com (https://github.com/EHANDBOOK/ehandbook-cb-demos)."),
		choice(name: 'workflowExecutionTarget', choices: ['GITHUB', 'NONE'], description: "Where to execute Container-Build-Cloud-Service-demo.yml: NONE or GITHUB.")
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
				script {
					artifactory.dockerLogin()
				}

				sh '''
					set -euo pipefail

					# Skip gracefully if no workflow files are present.
					if [ ! -d .github/workflows ]; then
						echo "No .github/workflows directory found. Skipping preflight checks."
						exit 0
					fi

					# Build a stable workflow file list for linters/checks.
					find .github/workflows -maxdepth 1 -type f '(' -name '*.yml' -o -name '*.yaml' ')' | sort > workflow-files.txt
					if [ ! -s workflow-files.txt ]; then
						echo "No workflow YAML files found. Skipping preflight checks."
						exit 0
					fi

					# 1) Semantic GitHub Actions validation with actionlint
					docker run --rm \\
						-v "$PWD:/repo" \\
						-w /repo \\
						artifactory.etas-dev.com/etasdev-docker-main/rhysd/actionlint:latest \\
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
				script {
					artifactory.dockerLogin()
				}

				sh '''
					set -e

					# Skip gracefully when no GitHub workflow/action files are present
					if [ ! -d .github/workflows ] && [ ! -f action.yml ] && [ ! -f .github/dependabot.yml ]; then
						echo "No GitHub Actions inputs found. Skipping zizmor."
						exit 0
					fi

					# Offline mode avoids GitHub API token requirements
					docker run --rm \
						-v "$PWD:/work" \
						-w /work \
						artifactory.etas-dev.com/ghcr-docker-remote/ghcr.io/zizmorcore/zizmor:latest \
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

		if (params.workflowExecutionTarget == 'GITHUB') {
			stage('Validate workflow on temporary GitHub branch') {
				dir(GIT_SYNC_FOLDER) {
					withCredentials([string(credentialsId: GITHUB_ACTIONS_DISPATCH_TOKEN_CREDENTIALS, variable: 'GH_TOKEN')]) {
						def originalCommit = git.getBuildCommit()
						def tempBranchName = ''
						def refToTest = 'main'

						if (params.workflowExecutionTarget == 'GITHUB') {
							tempBranchName = "jenkins-cb-wf-${env.BUILD_NUMBER}-${new Date().format('yyyyMMddHHmmss', TimeZone.getTimeZone('UTC'))}"
							refToTest = tempBranchName
							git.pushCurrentRepositoryToGitHubBranch(
								tempBranchName,
								"https://x-access-token:${GH_TOKEN}@github.com/EHANDBOOK/ehandbook-cb-demos.git",
								'chore(ci): temporary branch snapshot for workflow validation [skip ci]'
							)
						}

						withEnv([
							"ORIGINAL_COMMIT_ID=${originalCommit}",
							"TEMP_BRANCH_NAME=${tempBranchName}",
							"REF_TO_TEST_VALUE=${refToTest}",
							"DEMO_FOLDER_VALUE=Demo_EHBCB_DirBased_SL_Enhanced/Input",
							"STORAGE_TYPE_VALUE=GIT",
							"STORAGE_URL_VALUE=https://github.com/EHANDBOOK/ehandbook-cb-demos.git",
							"CONFIG_FILE_VALUE="
						]) {
							sh '''
							set -euo pipefail

							# config_File is optional; default to empty when not present to avoid set -u aborts.
							CONFIG_FILE_VALUE="${CONFIG_FILE_VALUE-}"

							REPO="EHANDBOOK/ehandbook-cb-demos"
							WORKFLOW_FILE="Container-Build-Cloud-Service-demo.yml"
							REF_TO_TEST="$REF_TO_TEST_VALUE"
							TEMP_BRANCH="$TEMP_BRANCH_NAME"
							ORIGINAL_COMMIT="$ORIGINAL_COMMIT_ID"

							api_call() {
								local method="$1"
								local url="$2"
								local output_file="$3"
								shift 3
								curl -sS -o "$output_file" -w "%{http_code}" \
									-X "$method" \
									-H "Authorization: Bearer ${GH_TOKEN}" \
									-H "Accept: application/vnd.github+json" \
									-H "X-GitHub-Api-Version: 2022-11-28" \
									"$@" \
									"$url"
							}

							require_status() {
								local actual="$1"
								local expected="$2"
								local message="$3"
								if [ "$actual" -ne "$expected" ]; then
									echo "${message} HTTP ${actual}" >&2
									exit 1
								fi
							}

							resolve_run_id() {
								local dispatch_time="$1"
								local run_id=""
								local attempt=0

								while [ -z "$run_id" ] && [ "$attempt" -lt 20 ]; do
									attempt=$((attempt+1))
									sleep 10

									lookup_status=$(api_call GET \
										"https://api.github.com/repos/${REPO}/actions/workflows/${WORKFLOW_FILE}/runs?event=workflow_dispatch&branch=${REF_TO_TEST}&per_page=50" \
										/tmp/gh-runs-response.txt)
									echo "Workflow runs lookup HTTP status: ${lookup_status}" >&2
									require_status "$lookup_status" 200 "Failed to query workflow runs."

									run_id=$(jq -r --arg dispatch_time "$dispatch_time" '(.workflow_runs // []) | .[] | select(.created_at >= $dispatch_time) | .id' /tmp/gh-runs-response.txt | head -n1)
								done

								if [ -z "$run_id" ]; then
									echo "Unable to identify dispatched workflow run ID." >&2
									exit 1
								fi

								echo "$run_id"
							}

							wait_for_run_completion() {
								local run_id="$1"
								local status="queued"
								local conclusion=""
								local attempt=0

								while [ "$attempt" -lt 180 ]; do
									attempt=$((attempt+1))
									sleep 20

									run_status_http=$(api_call GET \
										"https://api.github.com/repos/${REPO}/actions/runs/${run_id}" \
										/tmp/gh-run-response.txt)
									echo "Workflow run poll HTTP status: ${run_status_http}" >&2
									require_status "$run_status_http" 200 "Failed to query workflow run status."

									status=$(jq -r '.status // empty' /tmp/gh-run-response.txt)
									conclusion=$(jq -r '.conclusion // empty' /tmp/gh-run-response.txt)
									echo "GitHub run status: ${status} conclusion: ${conclusion:-n/a}" >&2

									if [ "$status" = "completed" ]; then
										break
									fi
								done

								if [ "$status" != "completed" ]; then
									echo "Timed out waiting for GitHub workflow run completion." >&2
									exit 1
								fi

								echo "$conclusion"
							}

							download_run_artifacts() {
								local run_id="$1"

								echo "Downloading workflow artifacts for run ID ${run_id}..."
								mkdir -p gh-workflow-artifacts

								artifacts_status_http=$(api_call GET \
									"https://api.github.com/repos/${REPO}/actions/runs/${run_id}/artifacts?per_page=100" \
									/tmp/gh-run-artifacts-response.txt)
								echo "Workflow artifacts lookup HTTP status: ${artifacts_status_http}"
								require_status "$artifacts_status_http" 200 "Failed to query workflow artifacts."

								cp /tmp/gh-run-artifacts-response.txt gh-workflow-artifacts/artifacts-metadata.json

								artifact_count=$(jq -r '.total_count // 0' /tmp/gh-run-artifacts-response.txt)
								if [ "$artifact_count" -eq 0 ]; then
									echo "No workflow artifacts found for run ID ${run_id}."
									return
								fi

								jq -r '(.artifacts // [])[] | @base64' /tmp/gh-run-artifacts-response.txt | while IFS= read -r artifact; do
									artifact_json=$(printf '%s' "$artifact" | base64 --decode)
									artifact_name=$(printf '%s' "$artifact_json" | jq -r '.name')
									artifact_id=$(printf '%s' "$artifact_json" | jq -r '.id')
									artifact_url=$(printf '%s' "$artifact_json" | jq -r '.archive_download_url')
									safe_name=$(printf '%s' "$artifact_name" | tr -cs '[:alnum:]._+-' '_')
									artifact_file="gh-workflow-artifacts/${safe_name}-${artifact_id}.zip"

									download_status=$(api_call GET "$artifact_url" "$artifact_file" -L)
									echo "Downloaded artifact '${artifact_name}' (id: ${artifact_id}) with HTTP status ${download_status}"
									if [ "$download_status" -ne 200 ]; then
										echo "Failed to download artifact '${artifact_name}' (id: ${artifact_id}). HTTP ${download_status}" >&2
										exit 1
									fi
								done
							}

							cleanup() {
								# Restore original checkout so later stages (publish/local execution) keep expected context.
								git checkout --detach "$ORIGINAL_COMMIT" >/dev/null 2>&1 || true

								if [ -n "$TEMP_BRANCH" ]; then
									echo "Deleting temporary GitHub branch: $TEMP_BRANCH"
									delete_status=$(curl -sS -o /tmp/gh-delete-response.txt -w "%{http_code}" -X DELETE \
										-H "Authorization: Bearer ${GH_TOKEN}" \
										-H "Accept: application/vnd.github+json" \
										-H "X-GitHub-Api-Version: 2022-11-28" \
										"https://api.github.com/repos/${REPO}/git/refs/heads/${TEMP_BRANCH}" || true)
									echo "Temporary branch delete HTTP status: ${delete_status:-curl_failed}"
								fi
							}
							trap cleanup EXIT

							if [ -n "$TEMP_BRANCH" ]; then
								echo "Using temporary GitHub branch: $TEMP_BRANCH"
							fi

							dispatch_time=$(date -u +%Y-%m-%dT%H:%M:%SZ)
							echo "Dispatching workflow at ${dispatch_time} using ref ${REF_TO_TEST}"

							payload=$(jq -n \
								--arg ref "$REF_TO_TEST" \
								--arg demo_folder "$DEMO_FOLDER_VALUE" \
								--arg storage_type "$STORAGE_TYPE_VALUE" \
								--arg storage_url "$STORAGE_URL_VALUE" \
								--arg config_File "$CONFIG_FILE_VALUE" \
								'{
									ref: $ref,
									inputs: {
										demo_folder: $demo_folder,
										storage_type: $storage_type,
										storage_url: $storage_url
									}
								} | if ($config_File | length) > 0 then .inputs.config_File = $config_File else . end')

							http_status=$(api_call POST \
								"https://api.github.com/repos/${REPO}/actions/workflows/${WORKFLOW_FILE}/dispatches" \
								/tmp/gh-dispatch-response.txt \
								-d "$payload")
							echo "Workflow dispatch HTTP status: ${http_status}"
							require_status "$http_status" 204 "Failed to dispatch workflow."

							echo "Workflow dispatched. Resolving run ID..."
							run_id=$(resolve_run_id "$dispatch_time")

							echo "Dispatched run ID: ${run_id}"
							echo "Run URL: https://github.com/${REPO}/actions/runs/${run_id}"
							conclusion=$(wait_for_run_completion "$run_id")

							if [ "$conclusion" != "success" ]; then
								jobs_status_http=$(api_call GET \
									"https://api.github.com/repos/${REPO}/actions/runs/${run_id}/jobs?per_page=100" \
									/tmp/gh-run-jobs-response.txt)
								echo "Workflow jobs lookup HTTP status: ${jobs_status_http}"
								if [ "$jobs_status_http" -eq 200 ]; then
									echo "Failed GitHub job/step summary:"
									has_failed_details=false

									while IFS=$'\t' read -r job_name job_status job_conclusion job_url; do
										[ -n "$job_name" ] || continue
										has_failed_details=true
										echo "Job: $job_name | status: $job_status | conclusion: $job_conclusion | url: $job_url"
									done < <(jq -r '(.jobs // [])[] | select((.conclusion // "") != "" and (.conclusion // "") != "success") | [(.name // "n/a"), (.status // "n/a"), (.conclusion // "n/a"), (.html_url // "n/a")] | @tsv' /tmp/gh-run-jobs-response.txt)

									while IFS=$'\t' read -r parent_job step_number step_name step_status step_conclusion; do
										[ -n "$parent_job" ] || continue
										has_failed_details=true
										echo "  Step in $parent_job: $step_number $step_name | status: $step_status | conclusion: $step_conclusion"
									done < <(jq -r '(.jobs // [])[] | .name as $job | (.steps // [])[] | select((.conclusion // "") != "" and (.conclusion // "") != "success") | [($job // "n/a"), ((.number // "?") | tostring), (.name // "n/a"), (.status // "n/a"), (.conclusion // "n/a")] | @tsv' /tmp/gh-run-jobs-response.txt)

									if [ "$has_failed_details" = false ]; then
										echo "No failed job/step details returned by GitHub API."
									fi
								else
									echo "Unable to fetch GitHub job details for failed run. HTTP ${jobs_status_http}" >&2
								fi
								echo "GitHub workflow completed with conclusion: ${conclusion}" >&2
								exit 1
							fi

							download_run_artifacts "$run_id"

							echo "GitHub workflow completed successfully."
						'''

							archiveArtifacts artifacts: 'gh-workflow-artifacts/*.zip,gh-workflow-artifacts/*.json', allowEmptyArchive: true
						}
					}
				}
			}
		}

		if (params.publishToGitHub) {
			stage('Publish to GitHub.com') {
				git.publishToGitHub(GIT_SYNC_FOLDER, 'EHANDBOOK', 'ehandbook-cb-demos', "Publish EHANDBOOK CB Demos to GitHub.com", false)
			}
		}
	}
}