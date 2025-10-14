using System;
using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.CustomPage
{
    /// <inheritdoc/>
    public class CustomPageModel : ICustomPageModel
    {
        /// <inheritdoc/>
        [Key(0)]
        public Guid ModuleId { get; set; }
        
        /// <inheritdoc/>
        [Key(1)]
        public string Content { get; set; } = null!;
        
        /// <inheritdoc/>
        [Key(2)]
        public bool IsCustomTemplate { get; init; }
    }
}