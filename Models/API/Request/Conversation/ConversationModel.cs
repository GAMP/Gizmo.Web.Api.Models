using System;
using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A conversation as its participants see it.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationModel : IWebApiModel
    {
        /// <summary>
        /// The conversation id.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid Id { get; init; }

        /// <summary>
        /// The purpose, fixed at creation.
        /// </summary>
        [MessagePack.Key(1)]
        public ConversationPurpose Purpose { get; init; }

        /// <summary>
        /// The person who created the conversation.
        /// </summary>
        [MessagePack.Key(2)]
        public ConversationReferenceModel Owner { get; init; } = null!;

        /// <summary>
        /// The branch the conversation belongs to; null when it has none.
        /// </summary>
        [MessagePack.Key(3)]
        public int? BranchId { get; init; }

        /// <summary>
        /// When the conversation was created (UTC).
        /// </summary>
        [MessagePack.Key(4)]
        public DateTime Created { get; init; }

        /// <summary>
        /// The current status.
        /// </summary>
        [MessagePack.Key(5)]
        public ConversationStatus Status { get; init; }

        /// <summary>
        /// The current participants, people and AIs.
        /// </summary>
        [MessagePack.Key(6)]
        public IEnumerable<ConversationReferenceModel> Participants { get; init; } = Enumerable.Empty<ConversationReferenceModel>();

        /// <summary>
        /// The AI that answers unaddressed messages; null when the conversation has no AI.
        /// </summary>
        [MessagePack.Key(7)]
        public ConversationAIReferenceModel? PrimaryAI { get; init; }
    }
}
