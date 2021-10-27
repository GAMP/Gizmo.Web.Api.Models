using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Point transaction filter class.
    /// </summary>
    [DataContract()]
    [Serializable()]
    public class PointTransactionFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// Return deposit transactions where the date greater than or equal to the specified date.
        /// </summary>
        [DataMember]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return deposit transactions where the date less than or equal to the specified date.
        /// </summary>
        [DataMember]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return deposit transactions of the specified user.
        /// </summary>
        [DataMember]
        public int? UserId { get; set; } 

        #endregion
    }
}
