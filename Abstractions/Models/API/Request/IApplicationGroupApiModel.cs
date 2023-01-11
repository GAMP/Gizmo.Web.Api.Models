﻿namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Application group.
    /// </summary>
    public interface IApplicationGroupApiModel : IWebApiClientModel
    {
        /// <summary>
        /// The name of the application group.
        /// </summary>
        string Name { get; set; }
    }
}