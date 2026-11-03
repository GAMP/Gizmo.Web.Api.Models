using MessagePack;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Billing profile duplicate.
    /// </summary>
    [MessagePackObject]
    public sealed class BillingProfileModelDuplicate
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the new billing profile.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        [StringLength(45)]
        public string NewName { get; set; } = null!;

        /// <summary>
        /// The host groups to assign to the new billing profile.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<int> HostGroupIds { get; set; } = Enumerable.Empty<int>();

        #endregion
    }
}
