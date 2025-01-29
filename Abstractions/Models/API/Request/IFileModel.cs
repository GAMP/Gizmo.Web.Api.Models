using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// File model.
    /// </summary>
    public interface IFileModel : IWebApiModel
    {
        /// <summary>
        /// File id.
        /// </summary>
        public int Id { get; init; }
        
        /// <summary>
        /// File guid identifier.
        /// </summary>
        public Guid Guid { get; init; }
        
        /// <summary>
        /// File name.
        /// </summary>
        public string Name { get; init; }
    }
}
