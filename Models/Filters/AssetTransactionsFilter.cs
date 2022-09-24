using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for asset transactions.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class AssetTransactionsFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// Return asset transactions where the date greater than or equal to the specified date.
        /// </summary>
        [Key(200)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return asset transactions where the date less than or equal to the specified date.
        /// </summary>
        [Key(201)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return asset transactions of the specified user.
        /// </summary>
        [Key(202)]
        public int? UserId { get; set; }

        /// <summary>
        /// Return active asset transactions.
        /// </summary>
        [Key(203)]
        public bool? IsActive { get; set; } 

        #endregion
    }
}
