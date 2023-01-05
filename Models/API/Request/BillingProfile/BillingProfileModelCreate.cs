#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Billing profile.
    /// </summary>
    [MessagePackObject]
    public sealed class BillingProfileModelCreate : IBillingProfileApiModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the billing profile.
        /// </summary>
        [MessagePack.Key(0)]
        [StringLength(255)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The default rate of the billing profile.
        /// </summary>
        [MessagePack.Key(1)]
        public BillingProfileRate? DefaultRate { get; set; }

        #endregion
    }
}
