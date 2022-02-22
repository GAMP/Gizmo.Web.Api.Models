using MessagePack;
using System;
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
    [MessagePackObject]
    public class ProductAvailability
    {
        #region PROPERTIES

        /// <summary>
        /// Whether the product is available only for a specific date range.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public bool DateRange { get; set; }

        /// <summary>
        /// The date from which the product starts to be available.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The date from which the product stops to be available.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Whether the product is available only for a specific time range within a day.
        /// </summary>
        [DataMember]
        [MessagePack.Key(3)]
        public bool TimeRange { get; set; }

        /// <summary>
        /// The days on which the product is available.
        /// </summary>
        [DataMember]
        [MessagePack.Key(4)]
        public IEnumerable<ProductAvailabilityDay> DaysAvailable { get; set; }

        #endregion
    }
}