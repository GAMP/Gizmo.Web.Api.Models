using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for invoice payments.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class InvoicePaymentsFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// Return invoice payments where the date greater than or equal to the specified date.
        /// </summary>
        [Key(200)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return invoice payments where the date less than or equal to the specified date.
        /// </summary>
        [Key(201)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return invoice payments of the specified invoice.
        /// </summary>
        [Key(202)]
        public int? InvoiceId { get; set; }

        /// <summary>
        /// Return invoice payments of the specified user.
        /// </summary>
        [Key(203)]
        public int? UserId { get; set; } 

        #endregion
    }
}