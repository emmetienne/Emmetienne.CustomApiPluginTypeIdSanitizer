using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Linq;

namespace Emmetienne.CustomApiPluginTypeIdSanitizer.Repository
{
    internal class PluginTypeRepository
    {
        private IOrganizationService organizationService;

        public PluginTypeRepository(IOrganizationService organizationService)
        {
            this.organizationService = organizationService;
        }

        public Entity GetPluginTypeIdByPlugintTypeName(string pluginTypeName)
        {
            if (string.IsNullOrEmpty(pluginTypeName))
                throw new ArgumentException("Plugin type name cannot be null or empty", nameof(pluginTypeName));

            var pluginTypeQuery = new QueryExpression("plugintype");

            pluginTypeQuery.NoLock = true;
            pluginTypeQuery.ColumnSet = new ColumnSet("plugintypeid");

            pluginTypeQuery.Criteria.AddCondition("name", ConditionOperator.Equal, pluginTypeName);

            return organizationService.RetrieveMultiple(pluginTypeQuery).Entities.FirstOrDefault();
        }

        public Entity GetPluginTypeNameFromPluginTypeId(Guid pluginTypeId)
        {
            if (pluginTypeId == Guid.Empty)
                throw new ArgumentException("Plugin type id cannot be empty", nameof(pluginTypeId));

            var pluginTypeQuery = new QueryExpression("plugintype");

            pluginTypeQuery.NoLock = true;
            pluginTypeQuery.ColumnSet = new ColumnSet("name");


            pluginTypeQuery.Criteria.AddCondition("plugintypeid", ConditionOperator.Equal, pluginTypeId);

            return organizationService.RetrieveMultiple(pluginTypeQuery).Entities.FirstOrDefault();
        }
    }
}
