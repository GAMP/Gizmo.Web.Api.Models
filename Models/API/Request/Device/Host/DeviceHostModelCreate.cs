#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device host relation model.
    /// </summary>
    [MessagePackObject]
    public sealed class DeviceHostModelCreate : IDeviceHostApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// Gets device id.
        /// </summary>
        [Key(0)]
        public int DeviceId { get; set; }

        #endregion
    }
}