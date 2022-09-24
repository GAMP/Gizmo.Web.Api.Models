using MessagePack;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product availability day.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductAvailabilityDay
    {
        #region PROPERTIES

        /// <summary>
        /// The day of the week.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public DayOfWeek Day { get; set; }

        /// <summary>
        /// The timespans during which the product is available for this day.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<ProductAvailabilityDayTime> DayTimesAvailable { get; set; }

        #endregion
    }
}