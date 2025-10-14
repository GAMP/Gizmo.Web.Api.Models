using System;

namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Custom page model
    /// </summary>
    public interface ICustomPageModel : IWebApiModel
    {
        /// <summary>
        /// Module id
        /// </summary>
        public Guid ModuleId { get; set; }
        
        /// <summary>
        /// Custom page content
        /// </summary>
        public string Content { get; set; }
        
        /// <summary>
        /// When custom template enabled user will only be able to specify entry Data.
        /// We will essentially be forcing him to provide his own visual template and data for the entry.
        /// </summary>
        public bool IsCustomTemplate { get; init; }
    }
}