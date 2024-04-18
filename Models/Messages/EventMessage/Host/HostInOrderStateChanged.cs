namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Host in order state changed message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("In order state changed", "HOST_IN_ORDER_STATE_CHANED_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Host in order state changed", "HOST_IN_ORDER_STATE_CHANED_EVENT_GROUP_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class HostInOrderStateChanged : HostEventMessageBase
    {
        /// <inheritdoc/>
        public HostInOrderStateChanged() : base()
        { }

        /// <summary>
        /// Indicates that host is marked as in order.
        /// </summary>
        [MessagePack.Key(2)]
        public bool InOrder
        {
            get;init;
        }
    }
}
