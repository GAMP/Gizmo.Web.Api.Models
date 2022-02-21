using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice payment.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class InvoicePayment : InvoicePaymentModelBase, IEntityBase
    {
        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// The date that the invoice payment was created.
        /// </summary>
        [DataMember]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the invoice this invoice payment is associated with.
        /// </summary>
        [DataMember]
        public int InvoiceId { get; set; }

        /// <summary>
        /// The Id of the operator this invoice payment is associated with.
        /// </summary>
        [DataMember]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this invoice payment is associated with.
        /// </summary>
        [DataMember]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this invoice payment is associated with.
        /// </summary>
        [DataMember]
        public int? RegisterId { get; set; }
    }
}