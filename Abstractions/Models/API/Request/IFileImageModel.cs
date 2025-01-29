using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// File image model.
    /// </summary>
    public interface IFileImageModel : IWebApiModel
    {
        /// <summary>
        /// File guid identifier.
        /// </summary>
        public Guid Id { get; init; }
        
        /// <summary>
        /// File name.
        /// </summary>
        public string FileName { get; init; }
        
        /// <summary>
        /// File mime type.
        /// </summary>
        public string MimeType { get; init; }
    }
}
