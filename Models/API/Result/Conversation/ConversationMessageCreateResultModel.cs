using System;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// The id and time the server gave a sent message.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationMessageCreateResultModel : IWebApiModel
    {
        /// <summary>
        /// The message id.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid Id { get; init; }

        /// <summary>
        /// When the message was stored (UTC).
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime Time { get; init; }
    }
}
