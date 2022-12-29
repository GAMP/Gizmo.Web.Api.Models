﻿using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device host relation model.
    /// </summary>
    [MessagePackObject()]
    public sealed class DeviceHost : IDeviceHostApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// Gets object id. 
        /// </summary>
        [Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// Gets host id.
        /// </summary>
        [Key(1)]
        public int HostId { get; set; }

        /// <summary>
        /// Gets device id.
        /// </summary>
        [Key(2)]
        public int DeviceId { get; set; }

        #endregion
    }
}
