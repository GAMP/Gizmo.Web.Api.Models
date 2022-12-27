using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Invoice.Payment
{
    /// <summary>
    /// Invoice payment.
    /// </summary>
    [MessagePackObject]
    public sealed class InvoicePaymentModelCreate : IInvoicePaymentApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the invoice this invoice payment is associated with.
        /// </summary>
        [MessagePack.Key(0)]
        public int InvoiceId { get; set; }

        /// <summary>
        /// The Id of the payment method this invoice payment is associated with.
        /// </summary>
        [MessagePack.Key(1)]
        public int PaymentMethodId { get; set; }

        /// <summary>
        /// The amount of the invoice payment.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The amount received for the invoice payment.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal AmountReceived { get; set; }

        #endregion
    }
}