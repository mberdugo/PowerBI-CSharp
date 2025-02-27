// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for DeploymentStepType.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(DeploymentStepTypeConverter))]
    public struct DeploymentStepType : System.IEquatable<DeploymentStepType>
    {
        private DeploymentStepType(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// A step for deploying a single dataset
        /// </summary>
        public static readonly DeploymentStepType DatasetDeployment = "DatasetDeployment";

        /// <summary>
        /// A step for deploying a single report
        /// </summary>
        public static readonly DeploymentStepType ReportDeployment = "ReportDeployment";

        /// <summary>
        /// A step for deploying a single dashboard
        /// </summary>
        public static readonly DeploymentStepType DashboardDeployment = "DashboardDeployment";

        /// <summary>
        /// A step for deploying a single dataflow
        /// </summary>
        public static readonly DeploymentStepType DataflowDeployment = "DataflowDeployment";


        /// <summary>
        /// Underlying value of enum DeploymentStepType
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for DeploymentStepType
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type DeploymentStepType
        /// </summary>
        public bool Equals(DeploymentStepType e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to DeploymentStepType
        /// </summary>
        public static implicit operator DeploymentStepType(string value)
        {
            return new DeploymentStepType(value);
        }

        /// <summary>
        /// Implicit operator to convert DeploymentStepType to string
        /// </summary>
        public static implicit operator string(DeploymentStepType e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum DeploymentStepType
        /// </summary>
        public static bool operator == (DeploymentStepType e1, DeploymentStepType e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum DeploymentStepType
        /// </summary>
        public static bool operator != (DeploymentStepType e1, DeploymentStepType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for DeploymentStepType
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is DeploymentStepType && Equals((DeploymentStepType)obj);
        }

        /// <summary>
        /// Returns for hashCode DeploymentStepType
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
