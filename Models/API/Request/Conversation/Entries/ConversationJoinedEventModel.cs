namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A participant joined the conversation by themselves; the owner joins this way when the conversation is created.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationJoinedEventModel : ConversationEntryModel
    {
        /// <summary>
        /// The participant who joined.
        /// </summary>
        [MessagePack.Key(5)]
        public ConversationReferenceModel Subject { get; init; } = null!;
    }
}
