using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment method.
    /// </summary>
    [MessagePackObject]
    public sealed class PaymentMethodModelCreate : IPaymentMethodApiModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the payment method.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// The display order of the payment method.
        /// </summary>
        [MessagePack.Key(1)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Whether the payment method is enabled.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Whether the payment method can be used by manager.
        /// </summary>
        [MessagePack.Key(3)]
        public bool AvailableInManager { get; set; }

        /// <summary>
        /// Whether the payment method can be used by clients.
        /// </summary>
        [MessagePack.Key(4)]
        public bool AvailableInClient { get; set; }

        /// <summary>
        /// Whether the payment method is deleted.
        /// </summary>
        [MessagePack.Key(5)]
        public bool IsDeleted { get; set; }

        #endregion
    }
}