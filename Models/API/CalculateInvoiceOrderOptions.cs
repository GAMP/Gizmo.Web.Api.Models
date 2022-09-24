using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice user order options.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class CalculateInvoiceOrderOptions : InvoiceOrderOptions
    {
        #region PROPERTIES
        
        /// <summary>
        /// The order object to invoice.
        /// </summary>
        [Key(100)]
        public CalculateOrderOptionsModelBase Order { get; set; } 

        #endregion
    }
}