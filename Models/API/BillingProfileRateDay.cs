﻿using MessagePack;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Billing profile rate day.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class BillingProfileRateDay
    {
        #region PROPERTIES

        /// <summary>
        /// The day of the week.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(0)]
        public DayOfWeek Day { get; set; }

        /// <summary>
        /// The timespans during which the rate is applicable for this day.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public IEnumerable<BillingProfileRateDayTime> DayTimesApplicable { get; set; }

        #endregion
    }
}