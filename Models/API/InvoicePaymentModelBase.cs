using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice payment.
    /// </summary>
    [Serializable]
    [DataContract]
    public class InvoicePaymentModelBase
    {
        /// <summary>
        /// The Id of the payment method this invoice payment is associated with.
        /// </summary>
        [DataMember]
        [Required]
        public int PaymentMethodId { get; set; }

        /// <summary>
        /// The amount of the invoice payment.
        /// </summary>
        [DataMember]
        public decimal Amount { get; set; }

        /// <summary>
        /// The amount received for the invoice payment.
        /// </summary>
        [DataMember]
        public decimal AmountReceived { get; set; }
    }
}
