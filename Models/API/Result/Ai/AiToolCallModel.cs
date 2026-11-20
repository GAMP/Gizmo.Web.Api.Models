using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A tool call made while producing an AI reply.
    /// </summary>
    [MessagePackObject]
    public sealed class AiToolCallModel : IWebApiModel
    {
        /// <summary>
        /// Opaque identifier of the tool call.
        /// </summary>
        [Key(0)]
        public string ToolCallId { get; init; } = string.Empty;

        /// <summary>
        /// Name of the executed tool.
        /// </summary>
        [Key(1)]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Outcome of the call. A denied call is an authorization outcome, not a provider error.
        /// </summary>
        [Key(2)]
        public AiToolCallStatus Status { get; init; }

        /// <summary>
        /// Stable redacted error identifier, for example "tool_denied"; never provider detail.
        /// </summary>
        [Key(3)]
        public string? ErrorCode { get; init; }
    }
}
