using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host device filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class HostDeviceFilter : IModelFilter<DeviceModel>
    {
        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Specifies explicit object id.
        /// </summary>
        [MessagePack.Key(1)]
        public int? Id { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [MessagePack.Key(2)]
        public List<string> Expand { get; set; } = new();

    }
}
