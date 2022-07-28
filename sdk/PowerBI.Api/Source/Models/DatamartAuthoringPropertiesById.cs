// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DatamartAuthoringPropertiesById
    {
        /// <summary>
        /// Initializes a new instance of the DatamartAuthoringPropertiesById
        /// class.
        /// </summary>
        public DatamartAuthoringPropertiesById()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatamartAuthoringPropertiesById
        /// class.
        /// </summary>
        /// <param name="modifiedById">The ID of the last user that modified
        /// the datamart</param>
        /// <param name="configuredById">The ID of the datamart owner</param>
        public DatamartAuthoringPropertiesById(string modifiedById = default(string), string configuredById = default(string))
        {
            ModifiedById = modifiedById;
            ConfiguredById = configuredById;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the last user that modified the datamart
        /// </summary>
        [JsonProperty(PropertyName = "modifiedById")]
        public string ModifiedById { get; set; }

        /// <summary>
        /// Gets or sets the ID of the datamart owner
        /// </summary>
        [JsonProperty(PropertyName = "configuredById")]
        public string ConfiguredById { get; set; }

    }
}
