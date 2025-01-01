using Emmetienne.Engines.Logging;
using Emmetienne.Engines.Patterns;
using Microsoft.Xrm.Sdk;
using System;

namespace Emmetienne.CustomApiPluginTypeIdSanitizer.EventBus
{
    public class EventBusSingleton : Singleton<EventBusSingleton>
    {
        #region Actions
        public Action clearSourcetEnvironmentName;
        public Action clearTargetEnvironmentName;
        public Action<bool> disableUiElements;
        public Action<bool> setDeleteTempExtractionFolder;
        public Action<Guid> retrieveSolutionComponents;
        public Action<IOrganizationService> changeSourceOrganizationService;
        public Action<IOrganizationService> changeTargetOrganizationService;
        public Action<string> setSourceEnvironmentName;
        public Action<string> setTargetEnvironmentName;
        public Action<string,string> initExtractSolution;
        public Action<string> initSearchCustomApi;
        public Action initSelectSanitizedSolutionPathFolder;
        public Action initSolutionZipToSanitizeFilePath;
        public Action<string> setSanitizedSolutionPath;
        public Action<string> setSolutionZipToSanitizeFilePath;
        #endregion

        #region UI
        public Action clearAllViews;
        public Action clearSolutionView;
        public Action clearSolutionComponentView;

        #endregion

        #region Logs
        public Action<LogModel> writeLog;
        #endregion
    }
}