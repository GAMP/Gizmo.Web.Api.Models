using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// File creation result model.
    /// </summary>
    public sealed class FileCreateResultModel : CreateResult, IWebApiModel
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <param name="guid">File guid.</param>
        public FileCreateResultModel(int id, Guid guid) : base(id)
        {
            Guid = guid;
        }

        /// <summary>
        /// File guid.
        /// </summary>
        public Guid Guid { get; }
    }
}
