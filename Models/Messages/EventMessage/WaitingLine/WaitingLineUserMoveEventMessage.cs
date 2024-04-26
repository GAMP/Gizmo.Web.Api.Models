using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Waiting line user move event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("User moved", "WAITING_LINE_USER_MOVED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("User moved event", "WAITING_LINE_USER_MOVED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class WaitingLineUserMoveEventMessage : WaitingLineEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public WaitingLineUserMoveEventMessage():base()
        {
        }

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
        /// Move type.
        /// </summary>
        [MessagePack.Key(4)]
        public WaitingLineMoveType MoveType
        {
            get; init;
        }

        /// <summary>
        /// New position.
        /// </summary>
        [MessagePack.Key(5)]
        public int Position
        {
            get;init;
        }
    }
}
