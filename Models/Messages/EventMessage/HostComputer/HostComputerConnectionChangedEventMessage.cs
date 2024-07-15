namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Host computer input lock changed event.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Connection changed", "HOST_COMPUTER_CONNECTION_CHANGED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Connection changed event", "HOST_COMPUTER_CONNECTION_CHANGED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class HostComputerConnectionChangedEventMessage : HostComputerEventMessageBase
    {
        /// <summary>
        /// Indicates that host computer is currently connected.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsConnected { get;init;}
    }
}
