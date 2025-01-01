using Emmetienne.CustomApiPluginTypeIdSanitizer.Components;
using Emmetienne.CustomApiPluginTypeIdSanitizer.Service;
using Emmetienne.CustomApiPluginTypeIdSanitizer.EventBus;
using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using System;
using XrmToolBox.Extensibility;

namespace Emmetienne.CustomApiPluginTypeIdSanitizer
{
    public partial class CustomApiPluginTypeIdSanitizer : MultipleConnectionsPluginControlBase
    {
        private Settings mySettings;

        private LogService logService;
        private FileHandlerService fileHandlerService;
        private CustomApiSanitizerService customApiSanitizerService;
        private ValidationService validationService;

        private SourceEnvironmentLabelView sourceEnvirontmentLabelView;
        private TargetEnvironmentLabelView targetEnvirontmentLabelView;
        private SelectSolutionZipButtonView selectSolutionZipButtonView;
        private SelectExportSolutionZipButtonView selectExportSolutionZipButtonView;
        private SanitizedSolutionExportPathTextBoxView sanitizedSolutionExportPathTextBoxView;
        private SourceSolutionTextBoxView sourceSolutionTextBoxView;
        private LoggingComponent loggingComponentView;

        public CustomApiPluginTypeIdSanitizer()
        {
            InitializeComponent();

            this.logService = new LogService();
            this.validationService = new ValidationService(this.logService);
            this.fileHandlerService = new FileHandlerService(this.logService);
            this.customApiSanitizerService = new CustomApiSanitizerService(this, fileHandlerService, this.logService);

            this.sourceEnvirontmentLabelView = new SourceEnvironmentLabelView(this.sourceEnvironmentConnectionToolStripButton);
            this.targetEnvirontmentLabelView = new TargetEnvironmentLabelView(this.targetEnvironmentConnectionToolStripButton);
            this.selectSolutionZipButtonView = new SelectSolutionZipButtonView(this.selectSolutionButton);
            this.selectExportSolutionZipButtonView = new SelectExportSolutionZipButtonView(this.sanitizedSolutionExportPathButton);
            this.sanitizedSolutionExportPathTextBoxView = new SanitizedSolutionExportPathTextBoxView(this.destinationFolderTextBox);
            this.sourceSolutionTextBoxView = new SourceSolutionTextBoxView(this.solutionPathTextBox);
            this.loggingComponentView = new LoggingComponent(this.loggingDataGridView);

            EventBusSingleton.Instance.setDeleteTempExtractionFolder?.Invoke(this.deleteTempExtractedFileCheckBox.Checked);
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            ShowInfoNotification("Visit my GitHub", new Uri("https://github.com/emmetienne"));
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            if (Service == newService)
                return;

            base.UpdateConnection(newService, detail, actionName, parameter);

            if (actionName.Equals("AdditionalOrganization", StringComparison.OrdinalIgnoreCase))
                return;

            EventBusSingleton.Instance.changeSourceOrganizationService?.Invoke(this.Service);
            EventBusSingleton.Instance.setSourceEnvironmentName?.Invoke(detail.ConnectionName);
            EventBusSingleton.Instance.clearAllViews?.Invoke();

            logService.LogWarning($"Source environment connection has changed to: {this.ConnectionDetail.WebApplicationUrl}");
        }

        private void TargetEnvironmentConnectionToolStripButton_Click(object sender, EventArgs e)
        {
            EventBusSingleton.Instance.disableUiElements?.Invoke(true);

            AddAdditionalOrganization();

            if (this.AdditionalConnectionDetails.Count == 0)
            {
                EventBusSingleton.Instance.disableUiElements?.Invoke(false);
                return;
            }

            if (this.AdditionalConnectionDetails != null && this.AdditionalConnectionDetails.Count > 1)
                this.RemoveAdditionalOrganization(this.AdditionalConnectionDetails[0]);

            EventBusSingleton.Instance.setTargetEnvironmentName?.Invoke(this.AdditionalConnectionDetails[0].ConnectionName);
            EventBusSingleton.Instance.changeTargetOrganizationService?.Invoke(this.AdditionalConnectionDetails[0].GetCrmServiceClient());

            EventBusSingleton.Instance.disableUiElements?.Invoke(false);

            logService.LogWarning($"Target environment connection has changed to: {this.AdditionalConnectionDetails[0].WebApplicationUrl}");
        }

        private void SanitizeButton_Click(object sender, EventArgs e)
        {
            var solutionPath = this.solutionPathTextBox.Text;
            var destinationPath = this.destinationFolderTextBox.Text;

            if (!validationService.TryValidate(this, solutionPath, destinationPath, this.logService))
                return;

            customApiSanitizerService.SanitizeCustomApiInSolution(solutionPath, destinationPath);
        }

        private void DeleteTempExtractedFile_CheckedChanged(object sender, EventArgs e)
        {
            EventBusSingleton.Instance.setDeleteTempExtractionFolder?.Invoke(this.deleteTempExtractedFileCheckBox.Checked);
        }
    }
}