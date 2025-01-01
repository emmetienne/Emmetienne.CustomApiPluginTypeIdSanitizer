using Emmetienne.CustomApiPluginTypeIdSanitizer.Model;
using Emmetienne.CustomApiPluginTypeIdSanitizer.Repository;
using Emmetienne.CustomApiPluginTypeIdSanitizer.EventBus;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using XrmToolBox.Extensibility;

namespace Emmetienne.CustomApiPluginTypeIdSanitizer.Service
{
    internal class CustomApiSanitizerService
    {
        private readonly PluginControlBase pluginControlBase;
        private readonly FileHandlerService fileHandlerService;
        private readonly LogService logService;

        private CustomApiRepository customApiRepository;
        private PluginTypeRepository sourcePluginTypeRepository;
        private PluginTypeRepository targetPluginTypeRepository;

        private bool deleteTempExtractedFolder = true;

        public CustomApiSanitizerService(MultipleConnectionsPluginControlBase pluginControlBase, FileHandlerService fileHandlerService, LogService logService)
        {
            this.pluginControlBase = pluginControlBase;
            this.fileHandlerService = fileHandlerService;
            this.logService = logService;

            if (pluginControlBase.ConnectionDetail != null)
            {
                var sourceOrganizationService = pluginControlBase.ConnectionDetail.GetCrmServiceClient();

                this.customApiRepository = new CustomApiRepository(sourceOrganizationService);
                this.sourcePluginTypeRepository = new PluginTypeRepository(sourceOrganizationService);
            }

            if (pluginControlBase.AdditionalConnectionDetails.Count > 1)
            {
                var targetOrganizationService = pluginControlBase.AdditionalConnectionDetails[0].GetCrmServiceClient();
                this.targetPluginTypeRepository = new PluginTypeRepository(targetOrganizationService);
                this.customApiRepository = new CustomApiRepository(targetOrganizationService);
            }

            EventBusSingleton.Instance.changeSourceOrganizationService += ChangeMainConnection;
            EventBusSingleton.Instance.changeTargetOrganizationService += ChangeTargetConnection;
            EventBusSingleton.Instance.setDeleteTempExtractionFolder += SetTemporaryExtractedFolderDeletion;
        }

        public void SanitizeCustomApiInSolution(string archiveFilePath, string destinationPath)
        {
            pluginControlBase.WorkAsync(new WorkAsyncInfo
            {
                Message = $@"Extracting solution",
                Work = (worker, args) =>
                {
                    try
                    {
                        var composedDestinationPath = $@"{destinationPath}\{Guid.NewGuid().ToString().Split('-').First()}_{archiveFilePath.Split('\\').Last().Split('.').First()}";

                        fileHandlerService.ExtractSolutionZip(archiveFilePath, composedDestinationPath);

                        worker.ReportProgress(0, $"Creating solution on target environment");

                        var customApiFolders = fileHandlerService.EnumerateFolders($@"{composedDestinationPath}\customapis");

                        var sourceEnvironmentCustomApiList = new List<CustomApiDefinition>();

                        foreach (var singleCustomApiFolder in customApiFolders)
                        {
                            var tmpMessage = $"Deserializing Custom API {Environment.NewLine}{singleCustomApiFolder.Split('\\').Last()}";
                            worker.ReportProgress(0, tmpMessage);
                            logService.LogInfo(tmpMessage);

                            var customApiDefinition = DeserializeCustomApi($@"{singleCustomApiFolder}\customapi.xml");
                            sourceEnvironmentCustomApiList.Add(customApiDefinition);
                        }

                        var targetEnvironmentCustomApiList = customApiRepository.GetCustomApiListByNames(sourceEnvironmentCustomApiList.Select(c => c.Name));

                        var differentPluginCustomApi = new List<CustomApiDefinition>();

                        foreach (var singleTargetEnvironmentCustomApi in targetEnvironmentCustomApiList)
                        {
                            var customApiName = singleTargetEnvironmentCustomApi.GetAttributeValue<string>("name");

                            worker.ReportProgress(0, $"Checking Custom API{Environment.NewLine}{customApiName}");

                            var customApiFromSourceEnvironment = sourceEnvironmentCustomApiList.FirstOrDefault(c => c.Name == customApiName);

                            if (customApiFromSourceEnvironment == null)
                                continue;

                            var targetEnvironmentPluginTypeId = singleTargetEnvironmentCustomApi.GetAttributeValue<EntityReference>("plugintypeid")?.Id;

                            if (customApiFromSourceEnvironment.PluginTypeId == targetEnvironmentPluginTypeId)
                            {
                                logService.LogInfo($"The PluginTypeId of the {customApiName} is the same between environments");
                                continue;
                            }

                            logService.LogDebug($"The PluginTypeId of the {customApiName} is not the same between environments");

                            var sourceEnvironmentPluginTypeName = sourcePluginTypeRepository.GetPluginTypeNameFromPluginTypeId(customApiFromSourceEnvironment.PluginTypeId.Value).GetAttributeValue<string>("name");

                            var differentCustomApi = customApiFromSourceEnvironment;


                            differentCustomApi.TargetEnvironmentPluginTypeId = targetPluginTypeRepository.GetPluginTypeIdByPlugintTypeName(sourceEnvironmentPluginTypeName)?.Id;

                            if (!differentCustomApi.TargetEnvironmentPluginTypeId.HasValue)
                            {
                                logService.LogDebug($"Plugin Type {sourceEnvironmentPluginTypeName} not found in target environment");
                                continue;
                            }

                            differentCustomApi.CustomApiData.plugintypeid.plugintypeexportkey = differentCustomApi.TargetEnvironmentPluginTypeId.ToString();

                            logService.LogDebug($"Plugin Type {sourceEnvironmentPluginTypeName} found in target environment");

                            differentPluginCustomApi.Add(differentCustomApi);
                        }

                        foreach (var singleDifferentCustomApi in differentPluginCustomApi)
                        {
                            var tmpMessage = $"Writing customapi.xml for Custom API{Environment.NewLine}{singleDifferentCustomApi.Name}";
                            worker.ReportProgress(0, tmpMessage);
                            logService.LogDebug(tmpMessage);

                            SerializeCustomApi(singleDifferentCustomApi.CustomApiData, $@"{composedDestinationPath}\customapis\{singleDifferentCustomApi.CustomApiData.uniquename}\customapi.xml");
                        }

                        worker.ReportProgress(0, "Compressing solution");
                        logService.LogInfo("Compressing solution");

                        var zipFileName = $@"{DateTime.Now.ToString("yyyyMMddhhmmss")}_{archiveFilePath.Split('\\').Last()}";
                        fileHandlerService.CompressFolderToZip(composedDestinationPath, $@"{destinationPath}", zipFileName);

                        logService.LogInfo($"Solution compressed at {destinationPath}\\{zipFileName}");

                        if (deleteTempExtractedFolder)
                        {
                            logService.LogInfo("Deleting temporary extracted folder");

                            Directory.Delete(composedDestinationPath, true);

                            logService.LogInfo("Temporary extracted folder deleted");
                        }
                    }
                    catch (Exception ex)
                    {
                        logService.LogError(ex.Message);
                    }
                },
                ProgressChanged = (args) =>
                {
                    pluginControlBase.SetWorkingMessage(args.UserState.ToString());
                },
                PostWorkCallBack = (args) =>
                {
                    EventBusSingleton.Instance.disableUiElements?.Invoke(false);
                }
            });
        }

        private CustomApiDefinition DeserializeCustomApi(string xmlFilePath)
        {
            if (string.IsNullOrEmpty(xmlFilePath))
                throw new ArgumentException("XML file path cannot be null or empty", nameof(xmlFilePath));

            if (!File.Exists(xmlFilePath))
                throw new FileNotFoundException("The specified XML file does not exist", xmlFilePath);

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(customapi));
                using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
                {
                    var deserializedCustomApi = (customapi)serializer.Deserialize(fileStream);

                    return new CustomApiDefinition(deserializedCustomApi);
                }
            }
            catch (InvalidOperationException ex)
            {
                // Log the error and the XML content for further analysis
                Console.WriteLine($"Error deserializing XML: {ex.Message}");
                Console.WriteLine(File.ReadAllText(xmlFilePath));
                throw new InvalidOperationException("An error occurred while deserializing the XML file", ex);
            }
        }

        private void SerializeCustomApi(customapi customApi, string filePath)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(customapi));
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    serializer.Serialize(fileStream, customApi);
                }
                Console.WriteLine("Serialization successful.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during serialization: {ex.Message}");
            }
        }

        public void ChangeMainConnection(IOrganizationService sourceIOrganizationService)
        {
            this.sourcePluginTypeRepository = new PluginTypeRepository(sourceIOrganizationService);
        }

        public void ChangeTargetConnection(IOrganizationService targetIOrganizationService)
        {
            this.customApiRepository = new CustomApiRepository(targetIOrganizationService);
            this.targetPluginTypeRepository = new PluginTypeRepository(targetIOrganizationService);
        }

        public void SetTemporaryExtractedFolderDeletion(bool deleteTempExtractedFolder)
        {
            this.deleteTempExtractedFolder = deleteTempExtractedFolder;
        }
    }
}