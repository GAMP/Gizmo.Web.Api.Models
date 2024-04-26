namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Waiting line user added event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("User added", "WAITING_LINE_USER_ADDED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("User added event", "WAITING_LINE_USER_ADDED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class WaitingLineUserAddedEventMessage : WaitingLineEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public WaitingLineUserAddedEventMessage() : base()
        { }

        /// <summary>
        /// Waiting line entry id.
        /// </summary>
        [MessagePack.Key(1)]
        public int EntryId
        {
            get;init;
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
    }
}
