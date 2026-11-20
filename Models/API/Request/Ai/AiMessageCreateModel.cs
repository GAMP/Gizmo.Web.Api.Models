using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// AI chat message model.
    /// </summary>
    /// <remarks>
    /// The caller supplies no tool name, tool arguments, operator id, or provider detail; those are
    /// decided server side.
    /// </remarks>
    [MessagePackObject]
    public sealed class AiMessageCreateModel : IWebApiModel
    {
        /// <summary>
        /// Client generated identifier that deduplicates a retried message within its session.
        /// </summary>
        [Key(0)]
        public string ClientRequestId { get; set; } = null!;

        /// <summary>
        /// Message text.
        /// </summary>
        [Key(1)]
        public string Message { get; set; } = null!;
    }
}
