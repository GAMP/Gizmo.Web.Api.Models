using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Preset reservation time filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PresetReservationTimeFilter : IModelFilter<PresetReservationTimeModel>
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();
    }
}
