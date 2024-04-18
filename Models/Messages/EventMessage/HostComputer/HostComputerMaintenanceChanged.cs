namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Host computer security changed event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Maintenance changed", "HOST_COMPUTER_MAINTENANCE_CHANGED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Maintenance changed event", "HOST_COMPUTER_MAINTENANCE_CHANGED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class HostComputerMaintenanceChanged : HostComputerEventMessageBase
    {
        /// <inheritdoc/>
        public HostComputerMaintenanceChanged() : base()
        { }

        /// <summary>
        /// Indicates that host computer in maintenance.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsInMaintenance
        {
            get;init;
        }
    }
}
