using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Period day.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PeriodDayModel : IWebApiModel
    {
        /// <summary>
        /// The day of the week.
        /// </summary>
        [MessagePack.Key(0)]
        [Range(0, 6)]
        public DayOfWeek Day { get; set; }

        /// <summary>
        /// Day times.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<PeriodDayTimeModel> DayTimes { get; set; } = Enumerable.Empty<PeriodDayTimeModel>();
    }
}
