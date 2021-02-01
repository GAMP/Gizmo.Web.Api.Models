using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order line delivered status.
    /// </summary>
    [DataContract]
    [Serializable]
    public class OrderLineDeliveredStatus
    {
        #region PROPERTIES

        /// <summary>
        /// The quantity of items in the order line.
        /// </summary>
        [DataMember]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The quantity of delivered items.
        /// </summary>
        [DataMember]
        public decimal DeliveredQuantity { get; set; }

        /// <summary>
        /// Whether all items have been delivered.
        /// </summary>
        [DataMember]
        public bool IsDelivered { get; set; }

        /// <summary>
        /// The date that all items were delivered.
        /// </summary>
        [DataMember]
        public DateTime? DeliveredTime { get; set; }

        #endregion
    }
}