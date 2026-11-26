using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// An AI turn ended without a reply; the author is the AI.
    /// </summary>
    /// <remarks>
    /// Visible to everyone, so the person waiting learns that no answer is coming. <see cref="ErrorMessage"/> and
    /// <see cref="Usage"/> are sent to staff only.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationAITurnFailedEventModel : ConversationEntryModel
    {
        /// <summary>
        /// The message the AI was answering.
        /// </summary>
        [MessagePack.Key(5)]
        public Guid TriggerId { get; init; }

        /// <summary>
        /// Why the turn failed.
        /// </summary>
        [MessagePack.Key(6)]
        public ConversationAITurnFailureStatus Status { get; init; }

        /// <summary>
        /// Details of the failure; staff only.
        /// </summary>
        [MessagePack.Key(7)]
        public string? ErrorMessage { get; init; }

        /// <summary>
        /// Tokens the turn used before it failed; staff only.
        /// </summary>
        [MessagePack.Key(8)]
        public ConversationUsageModel? Usage { get; init; }
    }
}
