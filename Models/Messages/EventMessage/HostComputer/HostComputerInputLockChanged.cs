namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Host computer input lock changed event.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Input lock changed", "HOST_COMPUTER_INPUT_LOCK_CHANGED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Input lock changed event", "HOST_COMPUTER_INPUT_LOCK_CHANGED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class HostComputerInputLockChanged : HostComputerEventMessageBase
    {
        /// <inheritdoc/>
        public HostComputerInputLockChanged() : base()
        { }

        /// <summary>
        /// Indicates that input is currently locked.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsLocked
        {
            get;init;
        }
    }
}
