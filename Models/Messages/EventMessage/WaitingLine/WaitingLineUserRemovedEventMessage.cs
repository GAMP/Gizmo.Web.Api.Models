using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Waiting line user removed event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("User removed", "WAITING_LINE_USER_REMOVED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("User removed event", "WAITING_LINE_USER_REMOVED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class WaitingLineUserRemovedEventMessage : WaitingLineEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public WaitingLineUserRemovedEventMessage() : base()
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
            get;init;
        }

        /// <summary>
        /// Removal reason.
        /// </summary>
        [MessagePack.Key(4)]
        public WaitingLineRemoveReason Reason
        {
            get;init;
        }
    }
}
