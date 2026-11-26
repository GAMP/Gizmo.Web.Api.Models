namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A participant was added; the author is who added them.
    /// </summary>
    /// <remarks>
    /// Adding a person is visible to everyone, adding an AI to staff only.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationAddedEventModel : ConversationEntryModel
    {
        /// <summary>
        /// The participant who was added.
        /// </summary>
        [MessagePack.Key(5)]
        public ConversationReferenceModel Subject { get; init; } = null!;
    }
}
