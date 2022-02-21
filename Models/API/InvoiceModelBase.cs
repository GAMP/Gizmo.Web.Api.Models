using MessagePack;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class InvoiceModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The date that the invoice was created.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the order this invoice is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public int OrderId { get; set; }

        /// <summary>
        /// The Id of the user this invoice is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public int UserId { get; set; }

        /// <summary>
        /// The status of the invoice.
        /// </summary>
        [DataMember]
        [EnumValue]
        [MessagePack.Key(3)]
        public InvoiceStatus Status { get; set; }

        /// <summary>
        /// The subtotal of the invoice.
        /// </summary>
        [DataMember]
        [MessagePack.Key(4)]
        public decimal SubTotal { get; set; }

        /// <summary>
        /// The total tax of the invoice.
        /// </summary>
        [DataMember]
        [MessagePack.Key(5)]
        public decimal TaxTotal { get; set; }

        /// <summary>
        /// The total amount of the invoice.
        /// </summary>
        [DataMember]
        [MessagePack.Key(6)]
        public decimal Total { get; set; }

        /// <summary>
        /// The outstanding amount of the invoice.
        /// </summary>
        [DataMember]
        [MessagePack.Key(7)]
        public decimal Outstanding { get; set; }

        /// <summary>
        /// The total points of the invoice.
        /// </summary>
        [DataMember]
        [MessagePack.Key(8)]
        public int PointsTotal { get; set; }

        /// <summary>
        /// The outstanding points of the invoice.
        /// </summary>
        [DataMember]
        [MessagePack.Key(9)]
        public int OutstandingPoints { get; set; }

        /// <summary>
        /// The Id of the operator this invoice is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(10)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this invoice is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(11)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this invoice is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(12)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// Whether the invoice is voided.
        /// </summary>
        [DataMember]
        [MessagePack.Key(13)]
        public bool IsVoided { get; set; }

        /// <summary>
        /// The lines of the invoice.
        /// </summary>
        [DataMember]
        [MessagePack.Key(14)]
        public IEnumerable<InvoiceLine> InvoiceLines { get; set; }

        /// <summary>
        /// The payments of the invoice.
        /// </summary>
        [DataMember]
        [MessagePack.Key(15)]
        public IEnumerable<InvoicePayment> InvoicePayments { get; set; }

        /// <summary>
        /// The refunds of the invoice.
        /// </summary>
        [DataMember]
        [MessagePack.Key(16)]
        public IEnumerable<InvoiceRefund> InvoiceRefunds { get; set; }

        #endregion
    }
}