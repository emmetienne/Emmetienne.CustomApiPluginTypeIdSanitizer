using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Emmetienne.CustomApiPluginTypeIdSanitizer.Repository
{
    internal class CustomApiRepository
    {
        private IOrganizationService organizationService;

        public CustomApiRepository(IOrganizationService organizationService)
        {
            this.organizationService = organizationService;
        }

        public IEnumerable<Entity> GetCustomApiListByNames(IEnumerable<string> customApiUniqueNames)
        {
            if (customApiUniqueNames == null || !customApiUniqueNames.Any())
                throw new ArgumentException("Custom API unique names cannot be null or empty", nameof(customApiUniqueNames));

            var customApiQuery = new QueryExpression("customapi")
            {
                NoLock = true,
                ColumnSet = new ColumnSet("name", "plugintypeid")
            };

            customApiQuery.Criteria.AddCondition("name", ConditionOperator.In, customApiUniqueNames.ToArray());

            var pluginTypeLink = customApiQuery.AddLink("plugintype", "plugintypeid", "plugintypeid", JoinOperator.LeftOuter);
            pluginTypeLink.EntityAlias = "plugintype";

            pluginTypeLink.Columns.AddColumns("name");


            var customApis = organizationService.RetrieveMultiple(customApiQuery).Entities;

            return customApis;
        }
    }
}
