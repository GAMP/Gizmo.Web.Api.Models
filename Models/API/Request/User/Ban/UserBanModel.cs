using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User ban.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class UserBanModel : IWebApiModel
    {
        /// <summary>
        /// The date where the ban will be revoked.
        /// </summary>
        [MessagePack.Key(0)]
        public DateTime? RevokeDate { get; set; }

        /// <summary>
        /// Optional ban reason id.
        /// </summary>
        [MessagePack.Key(1)]
        public int? BanReasonId { get; set; }

        /// <summary>
        /// Optional ban note.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(2)]
        public string? Note { get; init; }
    }
}
