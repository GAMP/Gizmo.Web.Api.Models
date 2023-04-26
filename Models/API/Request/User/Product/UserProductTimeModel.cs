using System;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User product time model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserProductTimeModel
    {
        /// <summary>
        /// The number of minutes of the time product.
        /// </summary>
        [Key(0)]
        public int Minutes { get; set; }

        /// <summary>
        /// The usage availability of the time product.
        /// </summary>
        [Key(1)]
        public ProductTimeUsageAvailabilityModel? UsageAvailability { get; set; }

        /// <summary>
        /// Whether the product is restricted for current host group.
        /// </summary>
        [Key(2)]
        public bool IsRestrictedForHostGroup { get; set; }
    }
}
