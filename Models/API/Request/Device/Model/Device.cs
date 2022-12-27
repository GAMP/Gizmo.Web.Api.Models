using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Device.Model
{
    /// <summary>
    /// Device model.
    /// </summary>
    [MessagePackObject()]
    public class Device : DeviceModelBase, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// Gets device id.
        /// </summary>
        [Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// Gets device type.
        /// </summary>
        [Key(101)]
        public DeviceType DeviceType { get; set; }

        #endregion
    }
}
