using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for invoices.
    /// </summary>
    [Serializable]
    [DataContract]
    public class InvoicesFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return invoices where the date greater than or equal to the specified date.
        /// </summary>
        [DataMember]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return invoices where the date less than or equal to the specified date.
        /// </summary>
        [DataMember]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return voided invoices.
        /// </summary>
        [DataMember]
        public bool? IsVoided { get; set; }

        /// <summary>
        /// Return invoices of the specified user.
        /// </summary>
        [DataMember]
        public int? UserId { get; set; }

    }
}