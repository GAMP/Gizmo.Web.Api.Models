using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for invoices.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class InvoicesFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return invoices where the date greater than or equal to the specified date.
        /// </summary>
        [DataMember]
        [MessagePack.Key(200)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return invoices where the date less than or equal to the specified date.
        /// </summary>
        [DataMember]
        [MessagePack.Key(201)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return voided invoices.
        /// </summary>
        [DataMember]
        [MessagePack.Key(202)]
        public bool? IsVoided { get; set; }

        /// <summary>
        /// Return invoices of the specified user.
        /// </summary>
        [DataMember]
        [MessagePack.Key(203)]
        public int? UserId { get; set; }

    }
}