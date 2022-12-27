﻿namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Device host relation model.
    /// </summary>
    public interface IDeviceHostApiModel
    {
        /// <summary>
        /// Gets device id.
        /// </summary>
        int DeviceId { get; set; }
    }
}