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
    public class InvoiceModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The date that the invoice was created.
        /// </summary>
        [DataMember]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the order this invoice is associated with.
        /// </summary>
        [DataMember]
        public int OrderId { get; set; }

        /// <summary>
        /// The Id of the user this invoice is associated with.
        /// </summary>
        [DataMember]
        public int UserId { get; set; }

        /// <summary>
        /// The status of the invoice.
        /// </summary>
        [DataMember]
        public InvoiceStatus Status { get; set; }

        /// <summary>
        /// The subtotal of the invoice.
        /// </summary>
        [DataMember]
        public decimal SubTotal { get; set; }

        /// <summary>
        /// The total tax of the invoice.
        /// </summary>
        [DataMember]
        public decimal TaxTotal { get; set; }

        /// <summary>
        /// The total amount of the invoice.
        /// </summary>
        [DataMember]
        public decimal Total { get; set; }

        /// <summary>
        /// The outstanding amount of the invoice.
        /// </summary>
        [DataMember]
        public decimal Outstanding { get; set; }

        /// <summary>
        /// The total points of the invoice.
        /// </summary>
        [DataMember]
        public int PointsTotal { get; set; }

        /// <summary>
        /// The outstanding points of the invoice.
        /// </summary>
        [DataMember]
        public int OutstandingPoints { get; set; }

        /// <summary>
        /// The Id of the operator this invoice is associated with.
        /// </summary>
        [DataMember]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this invoice is associated with.
        /// </summary>
        [DataMember]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this invoice is associated with.
        /// </summary>
        [DataMember]
        public int? RegisterId { get; set; }

        /// <summary>
        /// Whether the invoice is voided.
        /// </summary>
        [DataMember]
        public bool IsVoided { get; set; }

        /// <summary>
        /// The lines of the invoice.
        /// </summary>
        [DataMember]
        public IEnumerable<InvoiceLine> InvoiceLines { get; set; }

        /// <summary>
        /// The payments of the invoice.
        /// </summary>
        [DataMember]
        public IEnumerable<InvoicePayment> InvoicePayments { get; set; }

        /// <summary>
        /// The refunds of the invoice.
        /// </summary>
        [DataMember]
        public IEnumerable<InvoiceRefund> InvoiceRefunds { get; set; }

        #endregion
    }
}