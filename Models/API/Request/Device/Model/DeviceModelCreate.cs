using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Device.Model
{
    /// <summary>
    /// Device creation model.
    /// </summary>
    [Serializable]
    [MessagePackObject()]
    public class DeviceModelCreate : DeviceModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets device type.
        /// </summary>
        [Key(100)]
        public DeviceType DeviceType { get; set; }

        #endregion
    }
}
