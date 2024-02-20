using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice Information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class InvoiceDTOModel
    {
        /// <summary>
        /// Invoice Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int InvoiceId { get; set; }

        /// <summary>
        /// The creation time of the invoice.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// The Id of the operator that created the invoice.
        /// </summary>
        [MessagePack.Key(2)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The name of the operator that created the invoice.
        /// </summary>
        [MessagePack.Key(3)]
        public string? OperatorName { get; set; }

        /// <summary>
        /// The Id of the register on which the invoice was created.
        /// </summary>
        [MessagePack.Key(4)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// The name of the register on which the invoice was created.
        /// </summary>
        [MessagePack.Key(5)]
        public string? RegisterName { get; set; }

        /// <summary>
        /// The Id of the customer for whom the invoice was created.
        /// </summary>
        [MessagePack.Key(6)]
        public int? UserId { get; set; }

        /// <summary>
        /// The name of the customer for whom the invoice was created.
        /// </summary>
        [MessagePack.Key(7)]
        public string? UserName { get; set; }

        /// <summary>
        /// The Id of the user group the customer belongs to.
        /// </summary>
        [MessagePack.Key(8)]
        public int? UserGroupId { get; set; }

        /// <summary>
        /// Order source name.
        /// </summary>
        [MessagePack.Key(9)]
        public string? OrderSource { get; set; }

        /// <summary>
        /// The number of items in the invoice.
        /// </summary>
        [MessagePack.Key(10)]
        public int Quantity { get; set; }

        /// <summary>
        /// The tax amount of the invoice.
        /// </summary>
        [MessagePack.Key(11)]
        public decimal Tax { get; set; }

        /// <summary>
        /// The value of the invoice.
        /// </summary>
        [MessagePack.Key(12)]
        public decimal Value { get; set; }

        /// <summary>
        /// The value in points of the invoice.
        /// </summary>
        [MessagePack.Key(13)]
        public decimal PointsValue { get; set; }

        /// <summary>
        /// The points award of the invoice.
        /// </summary>
        [MessagePack.Key(14)]
        public int PointsAward { get; set; }

        /// <summary>
        /// Outstanding amount of the invoice. 
        /// </summary>
        [MessagePack.Key(15)]
        public decimal Outstanding { get; set; }

        /// <summary>
        /// The invoice is voided.
        /// </summary>
        [MessagePack.Key(16)]
        public bool IsVoided { get; set; }

        /// <summary>
        /// Refunded amount of the invoice.
        /// </summary>
        [MessagePack.Key(17)]
        public decimal RefundedAmount { get; set; }
    }
}
