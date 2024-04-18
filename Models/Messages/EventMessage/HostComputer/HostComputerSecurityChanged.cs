namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Host computer security changed event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Security changed", "HOST_COMPUTER_SECURITY_CHANGED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Security changed event", "HOST_COMPUTER_SECURITY_CHANGED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class HostComputerSecurityChanged : HostComputerEventMessageBase
    {
        /// <inheritdoc/>
        public HostComputerSecurityChanged() : base()
        { }

        /// <summary>
        /// Indicates that host computer security is enabled.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsSecure
        {
            get;init;
        }
    }
}
