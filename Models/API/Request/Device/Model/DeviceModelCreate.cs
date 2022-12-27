﻿using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Device.Model
{
    /// <summary>
    /// Device creation model.
    /// </summary>
    [MessagePackObject()]
    public sealed class DeviceModelCreate : IDeviceApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets device type.
        /// </summary>
        [MessagePack.Key(0)]
        public DeviceType DeviceType { get; set; }

        /// <summary>
        /// Gets or sets device name.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets if device is enabled.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// The hdmi device object attached to this device if the device is an hdmi device, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(3)]
        public HdmiDevice HdmiDevice { get; set; }

        #endregion
    }
}
