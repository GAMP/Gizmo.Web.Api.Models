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
    public class InvoicePaymentModelBase
    {
        #region PROPERTIES
        
        /// <summary>
        /// The Id of the payment method this invoice payment is associated with.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public int PaymentMethodId { get; set; }

        /// <summary>
        /// The amount of the invoice payment.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The amount received for the invoice payment.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal AmountReceived { get; set; } 

        #endregion
    }
}
