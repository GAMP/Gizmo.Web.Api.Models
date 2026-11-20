using MessagePack;

using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A configured AI connection offered for selection.
    /// </summary>
    [MessagePackObject]
    public sealed class AiConnectionModel : IWebApiModel
    {
        /// <summary>
        /// The connection, given by its existing integration id.
        /// </summary>
        [Key(0)]
        public int ConnectionId { get; init; }

        /// <summary>
        /// Display name of the connection.
        /// </summary>
        [Key(1)]
        public string DisplayName { get; init; } = string.Empty;

        /// <summary>
        /// Provider the connection is configured for, for example "deepseek".
        /// </summary>
        [Key(2)]
        public string Provider { get; init; } = string.Empty;

        /// <summary>
        /// Models selectable on this connection.
        /// </summary>
        [Key(3)]
        public IEnumerable<AiModelDescriptorModel> Models { get; init; } = Enumerable.Empty<AiModelDescriptorModel>();
    }
}
