using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time product usage availability.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class TimeProductUsageAvailability : ProductAvailability
    {
    }
}
