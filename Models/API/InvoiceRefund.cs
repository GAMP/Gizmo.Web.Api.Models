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
        public int Id { get; set; }

        /// <summary>
        /// The Id of the payment method used for the refund.
        /// </summary>
        [DataMember]
        public int RefundMethodId { get; set; }

        /// <summary>
        /// The refunded amount.
        /// </summary>
        [DataMember]
        public decimal Amount { get; set; }

        /// <summary>
        /// The date that the invoice refund was created.
        /// </summary>
        [DataMember]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the operator this invoice refund is associated with.
        /// </summary>
        [DataMember]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this invoice refund is associated with.
        /// </summary>
        [DataMember]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this invoice refund is associated with.
        /// </summary>
        [DataMember]
        public int? RegisterId { get; set; }
    }
}