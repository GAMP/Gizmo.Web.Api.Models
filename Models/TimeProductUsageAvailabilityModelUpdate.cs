using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time product usage availability.
    /// </summary>
    [Serializable]
    [DataContract]
    public class TimeProductUsageAvailabilityModelUpdate : TimeProductUsageAvailability, IUrlQueryParameters
    {
        public string ToQueryParameters()
        {
            return ParameterGenerator.Generate(this);
        }
    }
}