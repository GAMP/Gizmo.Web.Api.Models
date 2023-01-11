﻿namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Application group application.
    /// </summary>
    public interface IApplicationGroupApplicationApiModel : IWebApiClientModel
    {
        /// <summary>
        /// The Id of the application associated with this application group.
        /// </summary>
        int ApplicationId { get; set; }
    }
}