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
    public class OrderLineDeliveredStatusModelUpdate
    {
        #region PROPERTIES

        /// <summary>
        /// The quantity of delivered items.
        /// </summary>
        [DataMember]
        public decimal? DeliveredQuantity { get; set; }

        /// <summary>
        /// Whether all items have been delivered.
        /// </summary>
        [DataMember]
        public bool? IsDelivered { get; set; }

        #endregion
    }
}