using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace Emmetienne.CustomApiPluginTypeIdSanitizer.Service
{
    internal class ValidationService
    {

        private readonly LogService logService;

        public ValidationService(LogService logService)
        {
            this.logService = logService;
        }

        public bool TryValidate(MultipleConnectionsPluginControlBase multiplePluginControlBase,
                                string zippedSolutionFilePath, string destinationZippedSolutionFilePath, LogService logService)
        {
            var validationErrorsList = new List<string>();

            if (multiplePluginControlBase.Service == null)
            {
                validationErrorsList.Add("Source organization service is not set.");
            }

            if (multiplePluginControlBase.AdditionalConnectionDetails.Count == 0 || multiplePluginControlBase.AdditionalConnectionDetails[0].GetCrmServiceClient() == null)
            {
                validationErrorsList.Add("Target organization service is not set.");
            }

            if (string.IsNullOrWhiteSpace(zippedSolutionFilePath))
            {
                validationErrorsList.Add("Zipped solution file path is not set.");
            }

            if (string.IsNullOrWhiteSpace(destinationZippedSolutionFilePath))
            {
                validationErrorsList.Add("Destination zipped solution file path is not set.");
            }


            if (validationErrorsList.Count > 0)
            {
                MessageBox.Show($"- {string.Join($"{Environment.NewLine}- ", validationErrorsList)}", "Valdation errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logService.LogError(string.Join($" - ", validationErrorsList));
                return false;
            }

            return validationErrorsList.Count == 0;
        }


    }
}
