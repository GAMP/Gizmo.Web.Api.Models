using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for asset transactions.
    /// </summary>
    [Serializable]
    [DataContract]
    public class AssetTransactionsFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return asset transactions where the date greater than or equal to the specified date.
        /// </summary>
        [DataMember]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return asset transactions where the date less than or equal to the specified date.
        /// </summary>
        [DataMember]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return asset transactions of the specified user.
        /// </summary>
        [DataMember]
        public int? UserId { get; set; }

        /// <summary>
        /// Return active asset transactions.
        /// </summary>
        public bool? IsActive { get; set; }
    }
}
