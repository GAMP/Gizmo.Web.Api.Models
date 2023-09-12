using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Update result.
    /// </summary>
    [Serializable, MessagePackObject]
    public class UpdateResult
    {
        /// <summary>
        /// Default result.
        /// </summary>
        public static readonly UpdateResult Default = new();
    }
}
