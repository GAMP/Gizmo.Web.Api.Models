using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using Gizmo.Web.Api.Models.Models.API.Request.BillingProfile.Rate.Model;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.BillingProfile
{
    /// <summary>
    /// Billing profile.
    /// </summary>
    [MessagePackObject]
    public sealed class BillingProfileModelUpdate : IBillingProfileApiModel, IApiModelIdentifier, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The name of the billing profile.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// The default rate of the billing profile.
        /// </summary>
        [MessagePack.Key(2)]
        [Required]
        public BillingProfileRateModel DefaultRate { get; set; }

        #endregion
    }
}
