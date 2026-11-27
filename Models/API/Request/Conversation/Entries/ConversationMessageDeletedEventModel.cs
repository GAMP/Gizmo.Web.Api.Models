using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A message was deleted by its author; clients show the target message as deleted.
    /// </summary>
    /// <remarks>
    /// The original message stays in the history; this entry only changes what is shown.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationMessageDeletedEventModel : ConversationEntryModel
    {
        /// <summary>
        /// The id of the deleted message.
        /// </summary>
        [MessagePack.Key(5)]
        public Guid TargetId { get; init; }
    }
}
