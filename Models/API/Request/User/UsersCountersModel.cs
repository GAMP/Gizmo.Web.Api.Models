using MessagePack;

using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Users counters.
    /// </summary>
    [MessagePackObject]
    public sealed class UsersCountersModel
    {
        #region PROPERTIES

        /// <summary>
        /// Counters per user group.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<UserGroupCountersModel> CountersPerGroup { get; set; } = Enumerable.Empty<UserGroupCountersModel>();

        /// <summary>
        /// Total users.
        /// </summary>
        [MessagePack.Key(1)]
        public int TotalUsers { get; set; }

        /// <summary>
        /// Guest users.
        /// </summary>
        [MessagePack.Key(2)]
        public int GuestUsers { get; set; }

        /// <summary>
        /// Banned users.
        /// </summary>
        [MessagePack.Key(3)]
        public int BannedUsers { get; set; }

        /// <summary>
        /// Deleted users.
        /// </summary>
        [MessagePack.Key(4)]
        public int DeletedUsers { get; set; }

        /// <summary>
        /// Total user deposits.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal TotalUserDeposits { get; set; }

        #endregion
    }
}
