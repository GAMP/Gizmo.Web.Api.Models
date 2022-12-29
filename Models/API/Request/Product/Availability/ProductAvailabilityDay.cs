using MessagePack;

using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product availability day.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductAvailabilityDay
    {
        #region PROPERTIES

        /// <summary>
        /// The day of the week.
        /// </summary>
        [Key(0)]
        public DayOfWeek Day { get; set; }

        /// <summary>
        /// The timespans during which the product is available for this day.
        /// </summary>
        [Key(1)]
        public IEnumerable<ProductAvailabilityDayTime> DayTimesAvailable { get; set; }

        #endregion
    }
}