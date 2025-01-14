using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Task filter model. 
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class TaskFilter : IModelFilter<TaskModel>
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Task type.
        /// </summary>
        [MessagePack.Key(2)]
        public TaskType? Type { get; init; }

        /// <summary>
        /// Is deleted filter.
        /// </summary>
        [MessagePack.Key(3)]
        public bool? IsDeleted { get; init; }
    }
}
