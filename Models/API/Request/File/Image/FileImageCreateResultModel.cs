using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// File image creation result model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class FileImageCreateResultModel : IWebApiModel
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="id">File guid identifier.</param>
        public FileImageCreateResultModel(Guid id)
        {
            Id = id;
        }

        /// <summary>
        /// File guid identifier.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid Id { get; }
    }
}
