﻿using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for invoice payments.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class InvoicePaymentsFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return invoice payments where the date greater than or equal to the specified date.
        /// </summary>
        [DataMember]
        [MessagePack.Key(200)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return invoice payments where the date less than or equal to the specified date.
        /// </summary>
        [DataMember]
        [MessagePack.Key(201)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return invoice payments of the specified invoice.
        /// </summary>
        [DataMember]
        [MessagePack.Key(202)]
        public int? InvoiceId { get; set; }

        /// <summary>
        /// Return invoice payments of the specified user.
        /// </summary>
        [DataMember]
        [MessagePack.Key(203)]
        public int? UserId { get; set; }

    }
}