using MessagePack;

using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// AI chat message result.
    /// </summary>
    /// <remarks>
    /// One complete non-streaming reply; no provider payload, credential, or internal endpoint is
    /// carried back.
    /// </remarks>
    [MessagePackObject]
    public sealed class AiMessageResultModel : IWebApiModel
    {
        /// <summary>
        /// The session the message belongs to.
        /// </summary>
        [Key(0)]
        public string SessionId { get; init; } = string.Empty;

        /// <summary>
        /// Opaque identifier of this message.
        /// </summary>
        [Key(1)]
        public string MessageId { get; init; } = string.Empty;

        /// <summary>
        /// The connection the session was created on, given by its existing integration id.
        /// </summary>
        [Key(2)]
        public int ConnectionId { get; init; }

        /// <summary>
        /// The model that produced the reply.
        /// </summary>
        [Key(3)]
        public string ModelId { get; init; } = string.Empty;

        /// <summary>
        /// Reply text.
        /// </summary>
        [Key(4)]
        public string Content { get; init; } = string.Empty;

        /// <summary>
        /// Tools the model called while producing the reply, in call order.
        /// </summary>
        [Key(5)]
        public IEnumerable<AiToolCallModel> ToolCalls { get; init; } = Enumerable.Empty<AiToolCallModel>();
    }
}
