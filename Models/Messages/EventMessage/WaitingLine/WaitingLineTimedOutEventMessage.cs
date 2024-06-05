namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Waiting line timed out event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Timed out", "WAITING_LINE_TIMED_OUT_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Waiting line timed out event", "WAITING_LINE_TIMED_OUT_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class WaitingLineTimedOutEventMessage : WaitingLineEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public WaitingLineTimedOutEventMessage() : base()
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
    }
}
