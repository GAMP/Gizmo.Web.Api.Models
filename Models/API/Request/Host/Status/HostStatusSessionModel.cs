using System;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Active user session on a host.
    /// </summary>
    [MessagePackObject]
    public sealed class HostStatusSessionModel : IWebApiModel
    {
        /// <summary>
        /// User id.
        /// </summary>
        [Key(0)]
        public int UserId { get; init; }

        /// <summary>
        /// Username.
        /// </summary>
        [Key(1)]
        public string Username { get; init; } = string.Empty;

        /// <summary>
        /// Session state.
        /// </summary>
        [Key(2)]
        public UserSessionState State { get; init; }

        /// <summary>
        /// Session creation time.
        /// </summary>
        [Key(3)]
        public DateTime StartTime { get; init; }

        /// <summary>
        /// Total session running duration in seconds, independent of billing.
        /// </summary>
        [Key(4)]
        public double Span { get; init; }

        /// <summary>
        /// Remaining credited time in seconds. Null indicates unlimited time.
        /// </summary>
        [Key(5)]
        public double? CreditedTime { get; init; }
    }
}
