namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// The result of a tool call; the author is the AI.
    /// </summary>
    /// <remarks>
    /// Staff only. Answers the <see cref="ConversationToolCallModel"/> whose call id it repeats.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationToolResultModel : ConversationEntryModel
    {
        /// <summary>
        /// The id of the call this answers.
        /// </summary>
        [MessagePack.Key(5)]
        public string CallId { get; init; } = string.Empty;

        /// <summary>
        /// How the call ended.
        /// </summary>
        [MessagePack.Key(6)]
        public ConversationToolCallStatus Status { get; init; }

        /// <summary>
        /// The result as the AI received it, as JSON text: the tool's result, or an error object for a denied or failed call.
        /// </summary>
        [MessagePack.Key(7)]
        public string? Result { get; init; }

        /// <summary>
        /// A stable error code for a denied or failed call.
        /// </summary>
        [MessagePack.Key(8)]
        public string? ErrorCode { get; init; }
    }
}
