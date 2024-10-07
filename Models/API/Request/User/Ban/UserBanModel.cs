using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User ban.
    /// </summary>
    [MessagePackObject]
    public sealed class UserBanModel
    {
        #region PROPERTIES

        /// <summary>
        /// Whether the user is banned.
        /// </summary>
        [MessagePack.Key(0)]
        public bool IsBanned { get; set; }

        /// <summary>
        /// The date where the ban will be revoked.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime? EnableDate { get; set; }

        #endregion
    }
}
