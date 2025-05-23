using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Period model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PeriodModel : IWebApiModel
    {
        /// <summary>
        /// Enable date range.
        /// </summary>
        [MessagePack.Key(0)]
        public bool DateRange { get; init; }

        /// <summary>
        /// Range start date.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime? StartDate { get; init; }

        /// <summary>
        /// Range end date.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime? EndDate { get; init; }

        /// <summary>
        /// Enable day time range.
        /// </summary>
        [MessagePack.Key(3)]
        public bool TimeRange { get; init; }

        /// <summary>
        /// Period days.
        /// </summary>
        [MessagePack.Key(4)]
        public IEnumerable<PeriodDayModel> Days { get; set; } = Enumerable.Empty<PeriodDayModel>();

    }
}
