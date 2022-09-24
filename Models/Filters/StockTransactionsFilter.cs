using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for stock transactions.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class StockTransactionsFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// Return stock transactions where the date greater than or equal to the specified date.
        /// </summary>
        [Key(200)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return stock transactions where the date less than or equal to the specified date.
        /// </summary>
        [Key(201)]
        public DateTime? DateTo { get; set; } 

        #endregion
    }
}
