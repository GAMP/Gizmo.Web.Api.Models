namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Waiting line estimation changed event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Estimation changed", "WAITING_LINE_ESTIMATION_CHANGED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Estimation changed event", "WAITING_LINE_ESTIMATION_CHANGED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class WaitingLineEstimationChangedEventMessage : WaitingLineEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public WaitingLineEstimationChangedEventMessage() : base()
        { }

        /// <summary>
        /// Waiting line entry id.
        /// </summary>
        [MessagePack.Key(1)]
        public int EntryId
        {
            get; init;
        }

        /// <summary>
        /// Gets or sets host group id.
        /// </summary>
        [MessagePack.Key(2)]
        public int HostGroupId
        {
            get; init;
        }

        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(3)]
        public int UserId
        {
            get; init;
        }

        /// <summary>
        /// Estimated host id.
        /// </summary>
        [MessagePack.Key(4)]
        public int? EstimatedHostId
        {
            get; init;
        }

        /// <summary>
        /// Estimated wait time.
        /// </summary>
        [MessagePack.Key(5)]
        public double? EstimatedWaitTime
        {
            get; init;
        }
    }
}
