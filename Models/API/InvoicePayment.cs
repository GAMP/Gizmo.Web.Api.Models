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
        [MessagePack.Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The date that the invoice payment was created.
        /// </summary>
        [DataMember]
        [MessagePack.Key(101)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the invoice this invoice payment is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(102)]
        public int InvoiceId { get; set; }

        /// <summary>
        /// The Id of the operator this invoice payment is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(103)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this invoice payment is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(104)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this invoice payment is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(105)]
        public int? RegisterId { get; set; }
    }
}