using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product availability day.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ProductAvailabilityDay
    {
        /// <summary>
        /// The day of the week.
        /// </summary>
        [DataMember]
        public DayOfWeek Day { get; set; }

        /// <summary>
        /// The timespans within the day which the product is available.
        /// </summary>
        [DataMember]
        public IEnumerable<ProductAvailabilityDayTime> DayTimesAvailable { get; set; }
    }
}
