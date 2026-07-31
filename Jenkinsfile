final String LABEL = 'Linux_65'
library identifier: 'ehandbook-jenkins-library@13.1.15'

final String BITBUCKET_CREDENTIALS = '73ab8e6b-2e5b-409f-928c-c70f3ecd0094'

final String FOSSLENSE_PRODUCT_ID = '1661'
final String SOURCES_URI = 'https://bitbucket.etas-dev.com/scm/ehb/ehandbook-cb-demos.git'

final String GIT_SYNC_FOLDER = '.'

properties(jenkins.createBasicBuildProperties() + 
	parameters([
		booleanParam(name: 'publishToGitHub', description: "Publish the CB Demos to GitHub.com (https://github.com/EHANDBOOK/ehandbook-cb-demos).")
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

		stage('zizmor (GitHub Actions scan)') {
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
	}
}