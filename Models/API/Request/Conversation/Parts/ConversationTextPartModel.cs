namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A text part of a message.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationTextPartModel : ConversationPartModel
    {
        /// <summary>
        /// The text as markdown.
        /// </summary>
        [MessagePack.Key(0)]
        public string Markdown { get; init; } = string.Empty;
    }
}
