using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Device.Host
{
    /// <summary>
    /// Device host relation model.
    /// </summary>
    [MessagePackObject()]
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