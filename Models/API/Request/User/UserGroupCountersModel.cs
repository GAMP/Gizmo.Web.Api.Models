using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User group counters.
    /// </summary>
    [MessagePackObject]
    public sealed class UserGroupCountersModel
    {
        #region PROPERTIES

        /// <summary>
        /// User group Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// Total users within user group.
        /// </summary>
        [MessagePack.Key(1)]
        public int TotalUsers { get; set; }

        /// <summary>
        /// Total guest users within user group.
        /// </summary>
        [MessagePack.Key(2)]
        public int GuestUsers { get; set; }

        /// <summary>
        /// Total banned users within user group.
        /// </summary>
        [MessagePack.Key(3)]
        public int BannedUsers { get; set; }

        /// <summary>
        /// Total deleted users within user group.
        /// </summary>
        [MessagePack.Key(4)]
        public int DeletedUsers { get; set; }

        #endregion
    }
}
