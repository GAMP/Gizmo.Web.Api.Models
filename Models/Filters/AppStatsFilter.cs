using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application stat filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AppStatsFilter : IModelFilter<AppStatModel> , IBranchBasedModelFilter
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public List<string> Expand { get; set; } = [];

        /// <summary>
        /// Optional application id.
        /// </summary>
        [MessagePack.Key(1)]
        public int? AppId { get; set; }

        /// <summary>
        /// Optional application executable id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? AppExeId { get; set; }

        /// <summary>
        /// Optional host id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? HostId { get; set; }

        /// <summary>
        /// Optional user id.
        /// </summary>
        [MessagePack.Key(4)]
        public int? UserId { get; set; }

        /// <summary>
        /// Optional branch id.
        /// </summary>
        [MessagePack.Key(5)]
        public int? BranchId { get; set; }
    }
}
