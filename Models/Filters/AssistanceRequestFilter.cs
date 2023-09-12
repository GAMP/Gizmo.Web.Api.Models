using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Assistance request filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AssistanceRequestFilter : IModelFilter<AssistanceRequestModel>
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new List<string>();

        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? UserId { get; set; }

        /// <summary>
        /// Status.
        /// </summary>
        [MessagePack.Key(3)]
        public AssistanceRequestStatus? Status { get; set; }
    }
}
