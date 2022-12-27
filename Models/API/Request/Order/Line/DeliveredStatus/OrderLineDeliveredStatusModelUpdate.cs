using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Order.Line.DeliveredStatus
{
    /// <summary>
    /// Order line delivered status.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class OrderLineDeliveredStatusModelUpdate
    {
        #region PROPERTIES

        /// <summary>
        /// The quantity of delivered items.
        /// </summary>
        [Key(0)]
        public decimal? DeliveredQuantity { get; set; }

        /// <summary>
        /// Whether all items have been delivered.
        /// </summary>
        [Key(1)]
        public bool? IsDelivered { get; set; }

        #endregion
    }
}