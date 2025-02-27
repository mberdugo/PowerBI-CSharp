// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using System.Linq;

    /// <summary>
    /// The deployment pipeline dataset metadata.
    /// </summary>
    public partial class PipelineStageDataset : PipelineStageArtifactBase
    {
        /// <summary>
        /// Initializes a new instance of the PipelineStageDataset class.
        /// </summary>
        public PipelineStageDataset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PipelineStageDataset class.
        /// </summary>
        /// <param name="artifactId">The artifact ID.</param>
        /// <param name="artifactDisplayName">The artifact display
        /// name.</param>
        /// <param name="sourceArtifactId">The artifact ID from the workspace
        /// of the source stage, which will update the current artifact upon
        /// deployment. Applicable only when the user has at least contributor
        /// access to the source stage workspace.</param>
        /// <param name="targetArtifactId">The artifact ID from the workspace
        /// of the target stage, which will be updated by the current artifact
        /// upon deployment. Applicable only when the user has at least
        /// contributor access to the target stage workspace.</param>
        /// <param name="lastDeploymentTime">The artifact's last deployment
        /// time.</param>
        public PipelineStageDataset(System.Guid artifactId, string artifactDisplayName = default(string), System.Guid? sourceArtifactId = default(System.Guid?), System.Guid? targetArtifactId = default(System.Guid?), System.DateTime? lastDeploymentTime = default(System.DateTime?))
            : base(artifactId, artifactDisplayName, sourceArtifactId, targetArtifactId, lastDeploymentTime)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
