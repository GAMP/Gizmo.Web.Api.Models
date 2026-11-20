using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Active branch (club) with its computer counts and host group names, as seen by the user.
    /// </summary>
    [MessagePackObject]
    public sealed class UserBranchDetailsModel : IWebApiModel
    {
        /// <summary>
        /// Branch.
        /// </summary>
        [Key(0)]
        public UserBranchModel Branch { get; init; } = new();

        /// <summary>
        /// Number of non-deleted computers in the branch host groups.
        /// </summary>
        [Key(1)]
        public int TotalComputers { get; init; }

        /// <summary>
        /// Number of computers free now: not out of order, without an active session, not blocked by a reservation.
        /// </summary>
        [Key(2)]
        public int FreeComputers { get; init; }

        /// <summary>
        /// Names of the branch host groups that have at least one non-deleted computer, ordered by name.
        /// </summary>
        [Key(3)]
        public IEnumerable<string> HostGroups { get; init; } = Enumerable.Empty<string>();
    }
}
