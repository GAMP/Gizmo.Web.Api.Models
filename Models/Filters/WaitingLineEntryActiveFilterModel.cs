using Gizmo.Web.Api.Models.Abstractions;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Active waiting line entry filter model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class WaitingLineEntryActiveFilterModel : IModelFilter<WaitingLineEntryActiveModel>
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = [];

        /// <summary>
        /// Host group id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? HostGroupId
        {
            get; init;
        }
    }
}
