using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time product usage availability.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class TimeProductUsageAvailabilityModelUpdate : TimeProductUsageAvailability, IUrlQueryParameters
    {
    }
}