using Gizmo.Web.Api.Models.Models.API.Request.Device;

namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Device model base.
    /// </summary>
    public interface IDeviceApiModel
    {
        /// <summary>
        /// Gets or sets device name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets if device is enabled.
        /// </summary>
        bool IsEnabled { get; set; }

        /// <summary>
        /// The hdmi device object attached to this device if the device is an hdmi device, otherwise it will be null.
        /// </summary>
        HdmiDevice HdmiDevice { get; set; }
    }
}
