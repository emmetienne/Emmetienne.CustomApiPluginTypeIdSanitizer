# Emmetienne.CustomApiPluginTypeIdSanitizer

This tool is designed to address a gap in the Microsoft implementation of Custom APIs in Dynamics 365, particularly regarding the `plugintypeid` field. 

By default, Microsoft ties the `plugintypeid field to the GUID of the plugin type rather than the class name, which is unique by definition (and it's already used by the plugin steps).

This can lead to discrepancies when moving solutions between environments that have variable lenght development cycles, potentially preventing successful solution installation due to mismatched GUIDs.

This tool fills the gap by enabling users to sanitize the Custom APIs contained in a given solution by cleanse the `plugintypeid` using the expected value of the target environment, ensuring that the correct associations are maintained, and solutions can be deployed seamlessly across environments.

## Changelog

1.2025.1.5 - First release

## Features

- **Fix `plugintypeid` field discrepancies**: Automatically resolve differences in `plugintypeid` across environments.
- **Ensure consistent solution installations**: Remove the risk of installation failures due to GUID mismatches.
- **Works with Custom API plugins**: Designed specifically for scenarios where Custom APIs are involved in Dynamics 365.
- **Environment Migration Ready**: Facilitates smoother transitions between development, testing, and production environments.

## How this tool works

In Dynamics 365, when you export a solution containing Custom APIs, the `plugintypeid` is tied to the GUID of the plugin type rather than the class name itself, which is unique. 

When deploying the solution to another environment (e.g., from Dev to Test or Test to Prod), the GUIDs of the plugin types might differ, which causes the solution import to fail.

This tool identifies the `plugintypeid` that would be correct for the target environment and ensures they are consistent across by updating the `plugintypeid` field to match the correct GUID.

### Usage:
1. Select the source and target environments.
2. Select the zipped solution that contains the Custom APIs to be sanitized.
3. Select the destination folder where the sanitized solution zip will be placed.
4. Click on "Sanitize Custom API's in solution" button.
5. Wait for the process to finish.