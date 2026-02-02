using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User ban.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class UserBanModel : IWebApiModel
    {
        /// <summary>
        /// Whether the user is banned.
        /// </summary>
        [MessagePack.Key(0)]
        public bool IsBanned { get; set; }

        /// <summary>
        /// The date where the ban will be revoked.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime? RevokeDate { get; set; }

        /// <summary>
        /// Optional ban reason id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? BanReasonId { get; set; }

        /// <summary>
        /// Optional ban note.
        /// </summary>
        [MessagePack.Key(3)]
        public string? Note { get; init; }
    }
}
