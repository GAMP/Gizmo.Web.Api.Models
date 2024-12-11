namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Device event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Device", "BRANCH_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Device related events", "DEVICE_EVENT_GROUP_DESCRIPTION")]
    [EventGroup(21)]
    public abstract class DeviceEventMessageBase : APIEventMessage
    {
        /// <inheritdoc/>
        public DeviceEventMessageBase():base()
        {}
    }
}
