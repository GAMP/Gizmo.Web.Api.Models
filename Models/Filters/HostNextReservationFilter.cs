using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host next reservation filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class HostNextReservationFilter : IModelFilter<HostNextReservationModel>
    {
        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Specifies the start date.
        /// </summary>
        /// <remarks>
        /// This parameter will be used as starting point to search for next reservation.<br></br>
        /// Not specifying this value will cause the search to be done from current date-time.
        /// </remarks>
        [MessagePack.Key(2)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Specifies if deleted hosts should be included.
        /// </summary>
        [MessagePack.Key(3)]
        public bool IsDeleted { get; set; }
    }
}
