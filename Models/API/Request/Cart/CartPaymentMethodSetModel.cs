namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Cart payment method set model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CartPaymentMethodSetModel : IWebApiModel
    {
        /// <summary>
        /// Payment method id.
        /// </summary>
        [MessagePack.Key(0)]
        public int? PaymentMethodId { get; set; }
    }
}
