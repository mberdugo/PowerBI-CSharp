// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An entry defining a percentage of some target metric in a condition for
    /// Power BI goal status rule
    /// </summary>
    public partial class GoalsRulesPercentOf
    {
        /// <summary>
        /// Initializes a new instance of the GoalsRulesPercentOf class.
        /// </summary>
        public GoalsRulesPercentOf()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GoalsRulesPercentOf class.
        /// </summary>
        /// <param name="field">The field for which the percent value is
        /// computed</param>
        /// <param name="percent">The percent value</param>
        public GoalsRulesPercentOf(string field = default(string), double? percent = default(double?))
        {
            Field = field;
            Percent = percent;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the field for which the percent value is computed
        /// </summary>
        [JsonProperty(PropertyName = "field")]
        public string Field { get; set; }

        /// <summary>
        /// Gets or sets the percent value
        /// </summary>
        [JsonProperty(PropertyName = "percent")]
        public double? Percent { get; set; }

    }
}
