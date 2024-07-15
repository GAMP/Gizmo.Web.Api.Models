namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Client version change message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Client module version changed", "HOST_COMPUTER_CLIENT_MODULE_VERSION_CHANGED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Client module version changed event", "HOST_COMPUTER_CLIENT_MODULE_VERSION_CHANGED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class HostComputerClientModuleVersionChanged : HostComputerEventMessageBase
    {
        /// <summary>
        /// Current client module version.
        /// </summary>
        /// <remarks>
        /// Null if client version is unknown.
        /// </remarks>
        [MessagePack.Key(2)]
        public string? ModuleVersion { get; init; }
    }
}
