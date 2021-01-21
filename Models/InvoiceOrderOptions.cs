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
    public class InvoiceOrderOptions
    {
        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        public IEnumerable<InvoicePaymentModelBase> Payments { get; set; }

    }
}