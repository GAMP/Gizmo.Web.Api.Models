using System;
using System.Collections.Generic;
using System.Linq;
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
        /// The list of disallowed host groups.
        /// </summary>
        [Key(2)]
        public IEnumerable<int> DisallowedHostGroups { get; set; } = Enumerable.Empty<int>();

        /// <summary>
        /// Whether the product is restricted for current host group.
        /// </summary>
        [Key(3)]
        public bool IsRestrictedForHostGroup { get; set; }
    }
}
