namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// The conversation was closed.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationClosedEventModel : ConversationEntryModel
    {
        /// <summary>
        /// Why it was closed, if given.
        /// </summary>
        [MessagePack.Key(5)]
        public string? Reason { get; init; }
    }
}
