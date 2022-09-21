# GitHubActionsTestbed
Testbed examples of GitHub Actions.

## Examples
### .github/workflows/build-dotnet.yml
- An example with Composite Actions.

### .github/workflows/build-dotnet-with-pre-download.yml
- An example with Composite Actions.
- Preload `actions/upload-artifact` by declaring it previously.
  - This example avoids those delay downloads.
  - FYI: Downloading actions **in Composte Actions** will be delayed as a specification of GitHub Actions.

### .github/workflows/build-dotnet-with-setup-actions.yml
- An example with cached actions.
- All actions will be downloaded previously and will be shared in the steps.

### .github/workflows/build-dotnet-with-private-actions.yml
- An example with private actions.
- "Personal Access Token" (`secrets.PAT_TOKEN`) is required to access private repositories.
