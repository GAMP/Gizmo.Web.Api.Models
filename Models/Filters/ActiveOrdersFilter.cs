using Gizmo.Web.Api.Models.Abstractions;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Active orders filter model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ActiveOrdersFilter : IModelFilter<ActiveOrderModel>
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(3)]
        public List<string> Expand { get; set; } = new();
    }
}
