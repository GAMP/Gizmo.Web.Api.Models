using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for deposit transactions.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class DepositTransactionsFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// Return deposit transactions where the date greater than or equal to the specified date.
        /// </summary>
        [Key(200)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return deposit transactions where the date less than or equal to the specified date.
        /// </summary>
        [Key(201)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return deposit transactions of the specified user.
        /// </summary>
        [Key(202)]
        public int? UserId { get; set; } 

        #endregion
    }
}