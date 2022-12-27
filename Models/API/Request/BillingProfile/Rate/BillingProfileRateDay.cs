using MessagePack;

using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Models.API.Request.BillingProfile.Rate
{
    /// <summary>
    /// Billing profile rate day.
    /// </summary>
    [MessagePackObject]
    public sealed class BillingProfileRateDay
    {
        #region PROPERTIES

        /// <summary>
        /// The day of the week.
        /// </summary>
        [Key(0)]
        public DayOfWeek Day { get; set; }

        /// <summary>
        /// The timespans during which the rate is applicable for this day.
        /// </summary>
        [Key(1)]
        public IEnumerable<BillingProfileRateDayTime> DayTimesApplicable { get; set; }

        #endregion
    }
}
