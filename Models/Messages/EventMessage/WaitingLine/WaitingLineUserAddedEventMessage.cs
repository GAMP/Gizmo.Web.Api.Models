namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Waiting line user added event message.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class WaitingLineUserAddedEventMessage : WaitingLineEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public WaitingLineUserAddedEventMessage() : base()
        { }
  
        /// <summary>
        /// Gets or sets host group id.
        /// </summary>
        [MessagePack.Key(1)]
        public int HostGroupId
        {
            get; init;
        }

        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(2)]
        public int UserId
        {
            get;init;
        }
    }
}
