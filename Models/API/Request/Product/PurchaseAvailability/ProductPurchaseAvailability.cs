using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product purchase availability.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductPurchaseAvailability : IProductPurchaseAvailabilityApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// Whether the product is available only for a specific date range.
        /// </summary>
        [Key(0)]
        public bool DateRange { get; set; }

        /// <summary>
        /// The date from which the product starts to be available.
        /// </summary>
        [Key(1)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The date from which the product stops to be available.
        /// </summary>
        [Key(2)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Whether the product is available only for a specific time range within a day.
        /// </summary>
        [Key(3)]
        public bool TimeRange { get; set; }

        /// <summary>
        /// The days on which the product is available.
        /// </summary>
        [Key(4)]
        public IEnumerable<ProductAvailabilityDay> DaysAvailable { get; set; }

        #endregion
    }
}
