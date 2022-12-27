using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Device.Model
{
    /// <summary>
    /// Device model base.
    /// </summary>
    [MessagePackObject()]
    [Union(0, typeof(Device))]
    [Union(1, typeof(DeviceModelCreate))]
    [Union(2, typeof(DeviceModelUpdate))]
    public class DeviceModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets device name.
        /// </summary>
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets if device is enabled.
        /// </summary>
        [MessagePack.Key(1)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// The hdmi device object attached to this device if the device is an hdmi device, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(2)]
        public HdmiDevice HdmiDevice { get; set; }

        #endregion
    }
}
