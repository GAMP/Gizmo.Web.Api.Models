﻿namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Application license.
    /// </summary>
    public interface IApplicationLicenseApiModel
    {
        /// <summary>
        /// The plugin assembly of the license.
        /// </summary>        
        string Assembly { get; set; }

        /// <summary>
        /// The name of the license.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The plugin type name of the license.
        /// </summary>
        string Plugin { get; set; }
    }
}