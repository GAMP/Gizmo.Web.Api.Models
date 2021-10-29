using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Order invoiced event message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class OrderInvoicedEventMessage : OrderEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public OrderInvoicedEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets invoice id.
        /// </summary>
        [DataMember()]
        [Key(2)]
        public int InvoiceId
        {
            get; init;
        }

        #endregion
    }
}
