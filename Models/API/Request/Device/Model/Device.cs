﻿#nullable enable

using System.ComponentModel.DataAnnotations;

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device model.
    /// </summary>
    [MessagePackObject]
    public sealed class Device : IDeviceApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// Gets device id.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// Gets device type.
        /// </summary>
        [MessagePack.Key(1)]
        public DeviceType DeviceType { get; set; }

        /// <summary>
        /// Gets or sets device name.
        /// </summary>
        [MessagePack.Key(2)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets if device is enabled.
        /// </summary>
        [MessagePack.Key(3)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// The hdmi device object attached to this device if the device is an hdmi device, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(4)]
        public HdmiDevice? HdmiDevice { get; set; } //TODO: Is required?
        #endregion
    }
}
