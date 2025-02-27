// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Request to selectively deploy items from a deployment pipeline stage
    /// </summary>
    public partial class SelectiveDeployRequest : DeployRequestBase
    {
        /// <summary>
        /// Initializes a new instance of the SelectiveDeployRequest class.
        /// </summary>
        public SelectiveDeployRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SelectiveDeployRequest class.
        /// </summary>
        /// <param name="sourceStageOrder">The order of the pipeline stages
        /// that the content should be deployed from.</param>
        /// <param name="isBackwardDeployment">Whether the deployment should be
        /// done into the previous stage, if not provided treated as
        /// false.</param>
        /// <param name="newWorkspace">Required for creating a new workspace
        /// when deploying into a stage which has no assigned workspaces. If
        /// not provided when required, deployment will fail.</param>
        /// <param name="updateAppSettings">Update org app in the target
        /// workspace settings.</param>
        /// <param name="options">Options to control the behavior of the entire
        /// deployment.</param>
        /// <param name="datasets">A list of datasets to be deployed</param>
        /// <param name="reports">A list of reports to be deployed</param>
        /// <param name="dashboards">A list of dashboards to be
        /// deployed</param>
        /// <param name="dataflows">A list of dataflows to be deployed</param>
        public SelectiveDeployRequest(int sourceStageOrder, bool? isBackwardDeployment = default(bool?), PipelineNewWorkspaceRequest newWorkspace = default(PipelineNewWorkspaceRequest), PipelineUpdateAppSettings updateAppSettings = default(PipelineUpdateAppSettings), DeploymentOptions options = default(DeploymentOptions), IList<DeployArtifactRequest> datasets = default(IList<DeployArtifactRequest>), IList<DeployArtifactRequest> reports = default(IList<DeployArtifactRequest>), IList<DeployArtifactRequest> dashboards = default(IList<DeployArtifactRequest>), IList<DeployArtifactRequest> dataflows = default(IList<DeployArtifactRequest>))
            : base(sourceStageOrder, isBackwardDeployment, newWorkspace, updateAppSettings, options)
        {
            Datasets = datasets;
            Reports = reports;
            Dashboards = dashboards;
            Dataflows = dataflows;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of datasets to be deployed
        /// </summary>
        [JsonProperty(PropertyName = "datasets")]
        public IList<DeployArtifactRequest> Datasets { get; set; }

        /// <summary>
        /// Gets or sets a list of reports to be deployed
        /// </summary>
        [JsonProperty(PropertyName = "reports")]
        public IList<DeployArtifactRequest> Reports { get; set; }

        /// <summary>
        /// Gets or sets a list of dashboards to be deployed
        /// </summary>
        [JsonProperty(PropertyName = "dashboards")]
        public IList<DeployArtifactRequest> Dashboards { get; set; }

        /// <summary>
        /// Gets or sets a list of dataflows to be deployed
        /// </summary>
        [JsonProperty(PropertyName = "dataflows")]
        public IList<DeployArtifactRequest> Dataflows { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Datasets != null)
            {
                foreach (var element in Datasets)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Reports != null)
            {
                foreach (var element1 in Reports)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (Dashboards != null)
            {
                foreach (var element2 in Dashboards)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (Dataflows != null)
            {
                foreach (var element3 in Dataflows)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
        }
    }
}
