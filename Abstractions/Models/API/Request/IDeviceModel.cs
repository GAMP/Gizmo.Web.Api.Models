namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Device model base.
    /// </summary>
    public interface IDeviceModel : IWebApiModel
    {
        /// <summary>
        /// Gets or sets device name.
        /// </summary>
        string? Name { get; set; }

        /// <summary>
        /// Gets or sets if device is enabled.
        /// </summary>
        bool IsEnabled { get; set; }

        /// <summary>
        /// The HDMI device object attached to this device if the device is an HDMI device, otherwise it will be null.
        /// </summary>
        DeviceModelHdmi? HdmiDevice { get; set; }

        /// <summary>
        /// Branch id.
        /// </summary>
        int BranchId { get; set; }
    }
}
