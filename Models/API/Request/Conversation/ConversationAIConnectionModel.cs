using System;
using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// An enabled AI chat connection and the models it offers, for starting an AI conversation.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationAIConnectionModel : IWebApiModel
    {
        /// <summary>
        /// The public id of the AI chat connection (integration instance).
        /// </summary>
        [MessagePack.Key(0)]
        public Guid IntegrationId { get; init; }

        /// <summary>
        /// The connection's name, as the venue named the integration.
        /// </summary>
        [MessagePack.Key(1)]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// The models the connection offers; empty when they could not be listed.
        /// </summary>
        [MessagePack.Key(2)]
        public IEnumerable<ConversationAIModelInfoModel> Models { get; init; } = Enumerable.Empty<ConversationAIModelInfoModel>();

        /// <summary>
        /// Why the models could not be listed; null when they could.
        /// </summary>
        [MessagePack.Key(3)]
        public string? ErrorMessage { get; init; }
    }
}
