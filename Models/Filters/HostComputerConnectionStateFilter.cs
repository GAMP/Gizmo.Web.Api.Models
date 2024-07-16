using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host connection state filter model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class HostComputerConnectionStateFilter : IModelFilter<HostComputerConnectionStateModel>, IBranchBasedModelFilter
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = [];

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public int? BranchId { get; set; }

        /// <summary>
        /// Host computer id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? HostId { get; set; }
    }
}
