namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A customer asking for help.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ActionCenterAssistanceRequestedDetailsModel : ActionCenterEntryDetailsModel
    {
        /// <summary>
        /// The request to accept or reject.
        /// </summary>
        [MessagePack.Key(0)]
        public int AssistanceRequestId { get; init; }

        /// <summary>
        /// The customer asking.
        /// </summary>
        /// <remarks>
        /// Null on purpose rather than for want of knowing: a request can be raised against a station
        /// alone, with nobody attached to it. The manager shows the station and no customer.
        /// </remarks>
        [MessagePack.Key(1)]
        public int? UserId { get; init; }

        /// <summary>
        /// The station they are asking from.
        /// </summary>
        [MessagePack.Key(2)]
        public int HostId { get; init; }

        /// <summary>
        /// What sort of help, which the manager resolves to a name of its own.
        /// </summary>
        [MessagePack.Key(3)]
        public int AssistanceRequestTypeId { get; init; }

        /// <summary>
        /// What the customer typed, when they typed anything. The only free text on an entry, because
        /// it is theirs rather than ours.
        /// </summary>
        [MessagePack.Key(4)]
        public string? Note { get; init; }
    }
}
