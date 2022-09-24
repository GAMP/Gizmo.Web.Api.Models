using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice payment.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class InvoicePaymentModelCreate : InvoicePaymentModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the invoice this invoice payment is associated with.
        /// </summary>
        [Required]
        [MessagePack.Key(100)]
        public int InvoiceId { get; set; }

        #endregion
    }
}