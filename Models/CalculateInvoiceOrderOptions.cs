using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice user order options.
    /// </summary>
    [Serializable]
    [DataContract]
    public class CalculateInvoiceOrderOptions : InvoiceOrderOptions
    {
        /// <summary>
        /// The order object to invoice.
        /// </summary>
        [DataMember]
        public CalculateOrderOptionsModelBase Order { get; set; }
    }
}