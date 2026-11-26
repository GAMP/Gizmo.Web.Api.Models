using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A conversation to create.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationCreateModel : IWebApiModel
    {
        /// <summary>
        /// The purpose, fixed for the conversation's life.
        /// </summary>
        [MessagePack.Key(0)]
        public ConversationPurpose Purpose { get; init; }

        /// <summary>
        /// The participants to add besides the creator; the first AI becomes the primary AI.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<ConversationReferenceModel> Mentions { get; init; } = Enumerable.Empty<ConversationReferenceModel>();

        /// <summary>
        /// A first message to send right after creation.
        /// </summary>
        [MessagePack.Key(2)]
        public ConversationMessageCreateModel? FirstMessage { get; init; }
    }
}
