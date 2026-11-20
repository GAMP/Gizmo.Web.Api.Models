using MessagePack;

using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// AI connections the caller may select.
    /// </summary>
    /// <remarks>
    /// Only connections that are enabled and of the AI type are listed; an empty collection with
    /// <see cref="AiEnabled"/> set still means the feature is available.
    /// </remarks>
    [MessagePackObject]
    public sealed class AiConnectionsResultModel : IWebApiModel
    {
        /// <summary>
        /// Whether the AI feature is enabled on this server.
        /// </summary>
        [Key(0)]
        public bool AiEnabled { get; init; }

        /// <summary>
        /// Selectable connections.
        /// </summary>
        [Key(1)]
        public IEnumerable<AiConnectionModel> Connections { get; init; } = Enumerable.Empty<AiConnectionModel>();
    }
}
