using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Invoice.Payment
{
    /// <summary>
    /// Invoice payment.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class InvoicePayment : InvoicePaymentModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The date that the invoice payment was created.
        /// </summary>
        [Key(101)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the invoice this invoice payment is associated with.
        /// </summary>
        [Key(102)]
        public int InvoiceId { get; set; }

        /// <summary>
        /// The Id of the operator this invoice payment is associated with.
        /// </summary>
        [Key(103)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this invoice payment is associated with.
        /// </summary>
        [Key(104)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this invoice payment is associated with.
        /// </summary>
        [Key(105)]
        public int? RegisterId { get; set; }

        #endregion
    }
}