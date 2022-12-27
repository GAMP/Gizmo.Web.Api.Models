using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Device.Model
{
    /// <summary>
    /// Device update model.
    /// </summary>
    [Serializable]
    [MessagePackObject()]
    public class DeviceModelUpdate : DeviceModelBase, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <inheritdoc/>
        [Key(100)]
        public int Id { get; set; }

        #endregion
    }
}
