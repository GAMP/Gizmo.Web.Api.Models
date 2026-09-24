namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// An order waiting for an operator.
    /// </summary>
    /// <remarks>
    /// The order status is deliberately absent: the entry exists only while the order is on hold,
    /// and what happened to it afterwards is the entry's resolve reason. The total is absent too,
    /// because the manager keeps an active order lookup that already holds it.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class ActionCenterOrderDetailsModel : ActionCenterEntryDetailsModel
    {
        /// <summary>
        /// The order to open.
        /// </summary>
        [MessagePack.Key(0)]
        public int OrderId { get; init; }

        /// <summary>
        /// The customer waiting.
        /// </summary>
        [MessagePack.Key(1)]
        public int UserId { get; init; }

        /// <summary>
        /// Where they are sitting; null when the order is not tied to a station.
        /// </summary>
        [MessagePack.Key(2)]
        public int? HostId { get; init; }

        /// <summary>
        /// Whether it came from a station or the web, which the order lookup does not record and
        /// which changes whether somebody is waiting at a seat or at the counter.
        /// </summary>
        [MessagePack.Key(3)]
        public OrderSource Source { get; init; }
    }
}
