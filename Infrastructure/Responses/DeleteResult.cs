using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Delete result.
    /// </summary>
    [Serializable, MessagePackObject]
    public class DeleteResult
    {
        /// <summary>
        /// Default result.
        /// </summary>
        public static readonly DeleteResult Default = new();
    }
}
