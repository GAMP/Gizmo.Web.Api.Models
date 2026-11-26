using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A message of a person or an AI.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationMessageModel : ConversationEntryModel
    {
        /// <summary>
        /// The sender's own id for the message; null for AI messages.
        /// </summary>
        [MessagePack.Key(5)]
        public Guid? ClientMessageId { get; init; }

        /// <summary>
        /// The message content.
        /// </summary>
        [MessagePack.Key(6)]
        public IEnumerable<ConversationPartModel> Parts { get; init; } = Enumerable.Empty<ConversationPartModel>();

        /// <summary>
        /// The participants the message addresses.
        /// </summary>
        [MessagePack.Key(7)]
        public IEnumerable<ConversationReferenceModel> Mentions { get; init; } = Enumerable.Empty<ConversationReferenceModel>();

        /// <summary>
        /// For an AI message, the message it answers.
        /// </summary>
        [MessagePack.Key(8)]
        public Guid? TriggerId { get; init; }

        /// <summary>
        /// For an AI message, the tokens the turn used; sent to staff only.
        /// </summary>
        [MessagePack.Key(9)]
        public ConversationUsageModel? Usage { get; init; }
    }
}
