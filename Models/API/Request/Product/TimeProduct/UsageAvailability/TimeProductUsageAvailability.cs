using Gizmo.Web.Api.Models.Models.API.Request.Product.Availability;
using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.TimeProduct.UsageAvailability
{
    /// <summary>
    /// Time product usage availability.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class TimeProductUsageAvailability : ProductAvailability
    {
    }
}
