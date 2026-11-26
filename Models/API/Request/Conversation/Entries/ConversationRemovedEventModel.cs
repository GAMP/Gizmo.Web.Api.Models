namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A participant was removed; the author is who removed them.
    /// </summary>
    /// <remarks>
    /// Removing a person is visible to everyone, removing an AI to staff only.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationRemovedEventModel : ConversationEntryModel
    {
        /// <summary>
        /// The participant who was removed.
        /// </summary>
        [MessagePack.Key(5)]
        public ConversationReferenceModel Subject { get; init; } = null!;
    }
}
