using System;
using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A message to send.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationMessageCreateModel : IWebApiModel
    {
        /// <summary>
        /// The sender's own id for the message; sending the same id again returns the original message.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid ClientMessageId { get; init; }

        /// <summary>
        /// The message content.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<ConversationPartModel> Parts { get; init; } = Enumerable.Empty<ConversationPartModel>();

        /// <summary>
        /// The participants the message addresses; a mentioned AI answers.
        /// </summary>
        [MessagePack.Key(2)]
        public IEnumerable<ConversationReferenceModel> Mentions { get; init; } = Enumerable.Empty<ConversationReferenceModel>();

        /// <summary>
        /// Who may see the message and the AI's reply to it; only staff may send <see cref="ConversationVisibility.Staff"/>.
        /// </summary>
        [MessagePack.Key(3)]
        public ConversationVisibility Visibility { get; init; }
    }
}
