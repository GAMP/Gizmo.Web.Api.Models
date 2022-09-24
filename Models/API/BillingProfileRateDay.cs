using MessagePack;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Billing profile rate day.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class BillingProfileRateDay
    {
        #region PROPERTIES

        /// <summary>
        /// The day of the week.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public DayOfWeek Day { get; set; }

        /// <summary>
        /// The timespans during which the rate is applicable for this day.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<BillingProfileRateDayTime> DayTimesApplicable { get; set; }

        #endregion
    }
}
