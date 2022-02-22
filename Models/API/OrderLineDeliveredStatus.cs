using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order line delivered status.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class OrderLineDeliveredStatus
    {
        #region PROPERTIES

        /// <summary>
        /// The quantity of items in the order line.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The quantity of delivered items.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public decimal DeliveredQuantity { get; set; }

        /// <summary>
        /// Whether all items have been delivered.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public bool IsDelivered { get; set; }

        /// <summary>
        /// The date that all items were delivered.
        /// </summary>
        [DataMember]
        [MessagePack.Key(3)]
        public DateTime? DeliveredTime { get; set; }

        #endregion
    }
}