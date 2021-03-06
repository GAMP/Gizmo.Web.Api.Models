﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product availability.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ProductAvailability
    {
        #region PROPERTIES

        /// <summary>
        /// Whether the product is available only for a specific date range.
        /// </summary>
        [DataMember]
        public bool DateRange { get; set; }

        /// <summary>
        /// The date from which the product starts to be available.
        /// </summary>
        [DataMember]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The date from which the product stops to be available.
        /// </summary>
        [DataMember]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Whether the product is available only for a specific time range within a day.
        /// </summary>
        [DataMember]
        public bool TimeRange { get; set; }

        /// <summary>
        /// The days on which the product is available.
        /// </summary>
        [DataMember]
        public IEnumerable<ProductAvailabilityDay> DaysAvailable { get; set; }

        #endregion
    }
}