using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation host availability filter model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ReservationHostAvailabilityFilterModel : IModelFilter<ReservationAvailableHostModel>
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = ModelFilterPagination.DefaultUnlimited;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = [];

        /// <summary>
        /// Desired reservation start.
        /// </summary>
        [MessagePack.Key(2)]
        [Required()]
        public DateTime Start { get; set; }

        /// <summary>
        /// Desired reservation duration.
        /// </summary>
        [MessagePack.Key(3)]
        [Required()]
        [Range(1, int.MaxValue)]
        public int Duration { get; set; }

        /// <summary>
        /// Desired branch id.
        /// </summary>
        [MessagePack.Key(4)]
        [Required()]
        public int BranchId { get; init; }

        /// <summary>
        /// Participating user groups.
        /// </summary>
        [MessagePack.Key(5)]
        public List<int> UserGroups { get; set; } = [];
    }
}
