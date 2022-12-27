﻿namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Attribute.
    /// </summary>
    public interface IAttributeApiModel
    {
        /// <summary>
        /// The friendly name of the attribute.
        /// </summary>
        string FriendlyName { get; set; }

        /// <summary>
        /// The name of the attribute.
        /// </summary>
        string Name { get; set; }
    }
}