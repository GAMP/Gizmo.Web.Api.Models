namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Host locked state changed message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Lock state changed", "HOST_LOCK_STATE_CHANED_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Host lock state changed", "HOST_LOCK_STATE_CHANED_EVENT_GROUP_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class HostLockStateChanged : HostEventMessageBase
    {
        /// <inheritdoc/>
        public HostLockStateChanged() : base()
        { }

        /// <summary>
        /// Indicates that host is marked as in order.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsLocked
        {
            get;init;
        }
    }
}
