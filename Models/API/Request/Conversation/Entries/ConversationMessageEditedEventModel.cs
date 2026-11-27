using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A message was edited by its author; clients show <see cref="Parts"/> in place of the target message's content.
    /// </summary>
    /// <remarks>
    /// The original message stays in the history; this entry only replaces what is shown.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationMessageEditedEventModel : ConversationEntryModel
    {
        /// <summary>
        /// The id of the edited message.
        /// </summary>
        [MessagePack.Key(5)]
        public Guid TargetId { get; init; }

        /// <summary>
        /// The message content after the edit.
        /// </summary>
        [MessagePack.Key(6)]
        public IEnumerable<ConversationPartModel> Parts { get; init; } = Enumerable.Empty<ConversationPartModel>();
    }
}
