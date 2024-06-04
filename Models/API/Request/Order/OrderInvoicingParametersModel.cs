using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order invoicing parameters model.
    /// </summary>
    /// <remarks>
    /// Invoicing parameters for newly created orders.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class OrderInvoicingParametersModel : IWebApiModel
    {
        /// <summary>
        /// Indicates that invoice should be created.
        /// </summary>
        [MessagePack.Key(0)]
        public bool CreateInvoice
        {
            get; init;
        } = true;

        /// <summary>
        /// Preferred payment method id.
        /// </summary>
        /// <remarks>
        /// This parameter will be set on the order and will create payment on the order invoice with this method.
        /// </remarks>
        [MessagePack.Key(1)]
        public int? PreferredPaymentMethodId
        {
            get; init;
        }

        /// <summary>
        /// Order invoice payments to be executed.
        /// </summary>
        [MessagePack.Key(2)]
        public IEnumerable<PaymentCreateModel> Payments { get; init; } = [];

        /// <summary>
        /// Optional order source host id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? HostId
        {
            get; init;
        }

        /// <summary>
        /// If set overrides any host id specified and tries to obtain users currently logged in host.
        /// </summary>
        [MessagePack.Key(4)]
        public bool OverrideHostId
        {
            get; init;
        }

        /// <summary>
        /// Disable receipt printing.
        /// </summary>
        [MessagePack.Key(5)]
        public bool DisableReceiptPrinting { get; init; }
    }
}
