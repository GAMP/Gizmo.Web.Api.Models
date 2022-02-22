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
    public class InvoicePaymentModelCreate : InvoicePaymentModelBase
    {
        /// <summary>
        /// The Id of the invoice this invoice payment is associated with.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(100)]
        public int InvoiceId { get; set; }
    }
}