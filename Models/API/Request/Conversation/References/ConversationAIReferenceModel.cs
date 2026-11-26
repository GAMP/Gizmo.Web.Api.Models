using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Refers to an AI participant: one model of one AI chat connection.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationAIReferenceModel : ConversationReferenceModel
    {
        /// <summary>
        /// The public id of the AI chat connection (integration instance).
        /// </summary>
        [MessagePack.Key(2)]
        public Guid IntegrationId { get; init; }

        /// <summary>
        /// The model id within the connection.
        /// </summary>
        [MessagePack.Key(3)]
        public string ModelId { get; init; } = string.Empty;
    }
}
