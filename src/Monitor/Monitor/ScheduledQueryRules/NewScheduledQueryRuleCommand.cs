﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Insights.OutputClasses;
using Microsoft.Azure.Management.Monitor.Models;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;

namespace Microsoft.Azure.Commands.Insights.ScheduledQueryRules
{
    /// <summary>
    /// Create a ScheduledQueryRule Source object
    /// </summary>
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ScheduledQueryRule"), OutputType(typeof(PSScheduledQueryRuleResource))]
    public class NewScheduledQueryRuleCommand : ManagementCmdletBase
    {

        #region Cmdlet parameters

        //
        // Summary:
        //     Gets or sets source (Query, DataSourceId, etc.) for rule.
        [Parameter(Mandatory = true, HelpMessage = "The scheduled query rule source")]
        [ValidateNotNullOrEmpty]
        public PSScheduledQueryRuleSource Source { get; set; }

        //
        // Summary:
        //     Gets or sets schedule (Frequnecy, Time Window) for rule.
        [Parameter(Mandatory = false, HelpMessage = "The scheduled query rule schedule")]
        [ValidateNotNullOrEmpty]
        public PSScheduledQueryRuleSchedule Schedule { get; set; }

        //
        // Summary:
        //     Gets or sets action needs to be taken on rule execution.
        [Parameter(Mandatory = true, HelpMessage = "The scheduled query rule Alerting Action")]
        [ValidateNotNullOrEmpty]
        public PSScheduledQueryRuleAlertingAction Action { get; set; }

        //
        // Summary:
        //     Region where alert is to be created
        [Parameter(Mandatory = true, HelpMessage = "The location for this alert")]
        [ValidateNotNullOrEmpty]
        public string Location { get; set; }

        //
        // Summary:
        //     Alert description
        [Parameter(Mandatory = false, HelpMessage = "The description for this alert")]
        public string Description { get; set; }

        //
        // Summary:
        //     Alert name
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The alert name")]
        public string RuleName { get; set; }

        //
        // Summary:
        //     Resource tags
        [Parameter(Mandatory = false, HelpMessage = "The duration in minutes for which alert should be throttled")]
        public IDictionary<string, string> Tags;

        //
        // Summary:
        //     Alert status - enabled or not
        [Parameter(Mandatory = false, HelpMessage = "The azure alert state - valid values - true, false")]
        public string Enabled { get; set; }

        /// <summary>
        /// Gets or sets the ResourceGroupName parameter of the cmdlet
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The resource group name")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        #endregion
        protected override void ProcessRecordInternal()
        {
            PSScheduledQueryRuleResource response = null;

            try
            {
                var parameters = new LogSearchRuleResource(location: Location, source: Source, schedule: Schedule,
                    action: Action, tags: Tags, description: Description, enabled: Enabled);

                parameters.Validate(); //validate does not allow schedule to be null, while it is optional for us

                var result = this.MonitorManagementClient.ScheduledQueryRules
                    .CreateOrUpdateWithHttpMessagesAsync(resourceGroupName: ResourceGroupName, ruleName: RuleName,
                        parameters: parameters).Result;

                response = new PSScheduledQueryRuleResource(result.Body);
                WriteObject(response);
            }
            catch (Exception ex)
            {
                throw new Exception("Error occured while creating Log Alert rule", ex);
            }       
        }
    }
}
