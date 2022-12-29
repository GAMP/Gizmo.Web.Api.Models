using Gizmo.Web.Api.Models.Abstractions.Models.API.Filters;
using MessagePack;
using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for stock transactions.
    /// </summary>
    [MessagePackObject]
    public sealed class StockTransactionsFilter : IFilterModel
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public PaginationFilter PaginationFilter { get; set; }

        /// <summary>
        /// Return stock transactions where the date greater than or equal to the specified date.
        /// </summary>
        [Key(1)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return stock transactions where the date less than or equal to the specified date.
        /// </summary>
        [Key(2)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [MessagePack.Key(3)]
        public List<string> Expand { get; set; }

        #endregion
    }
}
