﻿using MessagePack;
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
    [MessagePackObject]
    public class InvoicePaymentModelBase
    {
        /// <summary>
        /// The Id of the payment method this invoice payment is associated with.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(0)]
        public int PaymentMethodId { get; set; }

        /// <summary>
        /// The amount of the invoice payment.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The amount received for the invoice payment.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public decimal AmountReceived { get; set; }
    }
}
