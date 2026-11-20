using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// AI chat session creation result.
    /// </summary>
    /// <remarks>
    /// The session lives in server memory and is bound to the authenticated caller; the identifier is
    /// opaque and is not a credential.
    /// </remarks>
    [MessagePackObject]
    public sealed class AiSessionResultModel : IWebApiModel
    {
        /// <summary>
        /// Opaque session identifier.
        /// </summary>
        [Key(0)]
        public string SessionId { get; init; } = string.Empty;

        /// <summary>
        /// The connection the session was created on, given by its existing integration id.
        /// </summary>
        [Key(1)]
        public int ConnectionId { get; init; }

        /// <summary>
        /// The model the session was created with.
        /// </summary>
        [Key(2)]
        public string ModelId { get; init; } = string.Empty;

        /// <summary>
        /// Session expiry time in UTC.
        /// </summary>
        [Key(3)]
        public DateTime ExpiresAt { get; init; }
    }
}
