using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

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
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// The default rate of the billing profile.
        /// </summary>
        [MessagePack.Key(1)]
        [Required]
        public BillingProfileRateModel DefaultRate { get; set; }

        #endregion
    }
}
