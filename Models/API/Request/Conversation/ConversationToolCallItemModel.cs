using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// One tool call an AI made.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationToolCallItemModel : IWebApiModel
    {
        /// <summary>
        /// The call id; the <see cref="ConversationToolResultModel"/> that answers it repeats it.
        /// </summary>
        [MessagePack.Key(0)]
        public string CallId { get; init; } = string.Empty;

        /// <summary>
        /// The tool's wire name.
        /// </summary>
        [MessagePack.Key(1)]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// The tool's display name.
        /// </summary>
        [MessagePack.Key(2)]
        public string Title { get; init; } = string.Empty;

        /// <summary>
        /// The arguments as the AI passed them: a JSON object, as text.
        /// </summary>
        [MessagePack.Key(3)]
        public string Arguments { get; init; } = "{}";
    }
}
