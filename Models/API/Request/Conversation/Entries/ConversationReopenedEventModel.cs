namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// The conversation was reopened.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationReopenedEventModel : ConversationEntryModel
    {
        /// <summary>
        /// Why it was reopened, if given.
        /// </summary>
        [MessagePack.Key(5)]
        public string? Reason { get; init; }
    }
}
