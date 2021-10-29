using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Order line state model.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class OrderLineStateModel
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public OrderLineStateModel()
        { } 
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets order line id.
        /// </summary>
        [DataMember()]
        [Key(0)]
        public int OrderLineId
        {
            get; set;
        }

        /// <summary>
        /// Gets if devlivered.
        /// </summary>
        [DataMember()]
        [Key(1)]
        public bool IsDelivered
        {
            get; set;
        }

        /// <summary>
        /// Gets devlivered quantity.
        /// </summary>
        [DataMember()]
        [Key(2)]
        public decimal DeliveredQuantity
        {
            get; set;
        }

        /// <summary>
        /// Gets delivery time.
        /// </summary>
        [DataMember()]
        [Key(3)]
        public DateTime? DeliverTime
        {
            get; set;
        }

        #endregion
    }
}
