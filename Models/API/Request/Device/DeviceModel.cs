using System;
using System.ComponentModel.DataAnnotations;

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class DeviceModel : IDeviceModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public DeviceType DeviceType { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        [StringLength(45)]
        public string? Name { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public bool IsEnabled { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public DeviceModelHdmi? HdmiDevice { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public int BranchId { get; set; }

        #endregion
    }
}
