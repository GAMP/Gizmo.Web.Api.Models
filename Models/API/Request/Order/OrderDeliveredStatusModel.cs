using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order delivery status.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderDeliveredStatusModel : IWebApiModel
    {
        /// <summary>
        /// Gets if order is marked as delivered.
        /// </summary>
        [MessagePack.Key(0)]
        public bool IsDelivered { get; init; }

        /// <summary>
        /// Gets deliver time.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime? DeliveredTime { get; init; }
    }
}
