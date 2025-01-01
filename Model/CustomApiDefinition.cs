using System;

namespace Emmetienne.CustomApiPluginTypeIdSanitizer.Model
{
    public class CustomApiDefinition
    {
        public string Name { get; set; }
        public Guid? PluginTypeId { get; set; }
        public Guid? TargetEnvironmentPluginTypeId { get; set; }
        public string PluginTypeName { get; set; }
        public customapi CustomApiData { get; set; }

        public CustomApiDefinition(customapi customApi)
        {
            Name = customApi.name;

            if (Guid.TryParse(customApi.plugintypeid?.plugintypeexportkey, out Guid pluginTypeId))
            {
                PluginTypeId = pluginTypeId;
            }

            CustomApiData = customApi;
        }
    }
}
