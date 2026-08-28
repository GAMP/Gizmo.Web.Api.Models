using System;

namespace Gizmo.Web.Api.Models.Models.API.Request
{
    public class CustomPageModel
    {
        [Key(0)]
        public Guid ModuleId { get; set; }
        
        [Key(1)]
        public string Content { get; set; } = null!;
    }
}