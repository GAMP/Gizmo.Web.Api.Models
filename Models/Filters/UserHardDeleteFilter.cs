using System;
using System.Collections.Generic;

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Users to hard delete filter.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserHardDeleteFilter : IModelFilter<UserHardDeleteModel>
    {
        /// <inheritdoc />
        [Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <inheritdoc />
        [Key(1)]
        public List<string> Expand { get; set; } = [];

        /// <summary>
        /// Deletes soft deleted users.
        /// </summary>
        [Key(2)]
        public bool? IsSoftDeleted { get; set; }
    }
}
