using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// An AI called a tool; the author is the AI.
    /// </summary>
    /// <remarks>
    /// Staff only. Written by the server before the tool runs, one call per entry; the
    /// <see cref="ConversationToolResultModel"/> with the same call id follows when the tool is done.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationToolCallModel : ConversationEntryModel
    {
        /// <summary>
        /// The message the AI was answering.
        /// </summary>
        [MessagePack.Key(5)]
        public Guid TriggerId { get; init; }

        /// <summary>
        /// The person whose message triggered the turn; the tool ran with their permissions.
        /// </summary>
        [MessagePack.Key(6)]
        public ConversationReferenceModel Caller { get; init; } = null!;

        /// <summary>
        /// The calls; one per entry today.
        /// </summary>
        [MessagePack.Key(7)]
        public IEnumerable<ConversationToolCallItemModel> Calls { get; init; } = Enumerable.Empty<ConversationToolCallItemModel>();
    }
}
