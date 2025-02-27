// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for PipelineUserAccessRight.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(PipelineUserAccessRightConverter))]
    public struct PipelineUserAccessRight : System.IEquatable<PipelineUserAccessRight>
    {
        private PipelineUserAccessRight(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// Grants administrator rights to a deployment pipeine
        /// </summary>
        public static readonly PipelineUserAccessRight Admin = "Admin";


        /// <summary>
        /// Underlying value of enum PipelineUserAccessRight
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for PipelineUserAccessRight
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type PipelineUserAccessRight
        /// </summary>
        public bool Equals(PipelineUserAccessRight e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to PipelineUserAccessRight
        /// </summary>
        public static implicit operator PipelineUserAccessRight(string value)
        {
            return new PipelineUserAccessRight(value);
        }

        /// <summary>
        /// Implicit operator to convert PipelineUserAccessRight to string
        /// </summary>
        public static implicit operator string(PipelineUserAccessRight e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum PipelineUserAccessRight
        /// </summary>
        public static bool operator == (PipelineUserAccessRight e1, PipelineUserAccessRight e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum PipelineUserAccessRight
        /// </summary>
        public static bool operator != (PipelineUserAccessRight e1, PipelineUserAccessRight e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for PipelineUserAccessRight
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is PipelineUserAccessRight && Equals((PipelineUserAccessRight)obj);
        }

        /// <summary>
        /// Returns for hashCode PipelineUserAccessRight
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
