using MessagePack;
using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice order options.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class InvoiceOrderOptions
    {
        #region PROPERTIES
        
        /// <summary>
        /// The list of payments for the invoice.
        /// </summary>
        [Key(0)]
        public IEnumerable<InvoicePaymentModelBase> Payments { get; set; } 

        #endregion
    }
}