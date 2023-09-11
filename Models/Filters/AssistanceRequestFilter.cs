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
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <inheritdoc/>
        public List<string> Expand { get; set; } = new List<string>();

        /// <summary>
        /// User id.
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Status.
        /// </summary>
        public AssistanceRequestStatus? Status { get; set; }
    }
}
