using MessagePack;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice order options.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class InvoiceOrderOptions
    {
        /// <summary>
        /// The list of payments for the invoice.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public IEnumerable<InvoicePaymentModelBase> Payments { get; set; }

    }
}