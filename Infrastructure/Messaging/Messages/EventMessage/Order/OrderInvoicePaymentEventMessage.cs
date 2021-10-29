using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Order invoice payment event message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class OrderInvoicePaymentEventMessage : OrderEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public OrderInvoicePaymentEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets payment method id.
        /// </summary>
        [DataMember()]
        [Key(2)]
        public int? PaymentMethodId
        {
            get; init;
        }

        /// <summary>
        /// Gets payment amount.
        /// </summary>
        [DataMember()]
        [Key(3)]
        public decimal Amount
        {
            get; init;
        }

        /// <summary>
        /// Get outstanding amount on invoice.
        /// </summary>
        [DataMember()]
        [Key(4)]
        public decimal Outstanding
        {
            get; init;
        }

        #endregion
    }
}
