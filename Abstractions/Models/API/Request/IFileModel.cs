using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// File model.
    /// </summary>
    public interface IFileModel : IWebApiModel
    {
        /// <summary>
        /// File name.
        /// </summary>
        public string FileName { get; init; }
        
        /// <summary>
        /// File mime type.
        /// </summary>
        public string MimeType { get; init; }
        
        /// <summary>
        /// File identifier.
        /// </summary>
        public Guid Guid { get; init; }
    }
}
