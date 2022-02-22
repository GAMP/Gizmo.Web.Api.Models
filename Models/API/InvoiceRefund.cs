using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice refund.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class InvoiceRefund : IEntityBase
    {
        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the payment method used for the refund.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public int RefundMethodId { get; set; }

        /// <summary>
        /// The refunded amount.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The date that the invoice refund was created.
        /// </summary>
        [DataMember]
        [MessagePack.Key(3)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the operator this invoice refund is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(4)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this invoice refund is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(5)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this invoice refund is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(6)]
        public int? RegisterId { get; set; }
    }
}