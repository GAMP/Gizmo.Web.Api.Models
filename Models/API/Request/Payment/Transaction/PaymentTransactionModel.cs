using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment transaction model.
    /// </summary>
    /// <remarks>
    /// Represents payment transaction, includes invoice,depoist pay ins/outs etc.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class PaymentTransactionModel : IWebApiModel
    {
        /// <summary>
        /// Optional shift id.
        /// </summary>
        /// <remarks>
        /// This might be null in some cases for example for online deposit or when shifts not used.
        /// </remarks>
        [MessagePack.Key(0)]
        public int? ShiftId
        {
            get; init;
        }

        /// <summary>
        /// Gets transaction date.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime Date
        {
            get; init;
        }

        /// <summary>
        /// Gets transaction amount.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Amount
        {
            get; init;
        }

        /// <summary>
        /// Optional operator id.
        /// </summary>
        /// <remarks>
        /// This might be null in some cases for example for online deposit.
        /// </remarks>
        [MessagePack.Key(3)]
        public int? OperatorId
        {
            get; init;
        }

        /// <summary>
        /// Optional user id.
        /// </summary>
        [MessagePack.Key(4)]
        public int? UserId
        {
            get;init;
        }

        /// <summary>
        /// Gets payment transaction type.
        /// </summary>
        [MessagePack.Key(5)]
        public PaymentTransactionType Type
        {
            get; init;
        }

        /// <summary>
        /// Gets transaction payment method.
        /// </summary>
        [MessagePack.Key(6)]
        public int PaymentMthodId
        {
            get; init;
        }

        /// <summary>
        /// Optional transaction host id.
        /// </summary>
        [MessagePack.Key(7)]
        public int? HostId
        {
            get; init;
        }

        /// <summary>
        /// Optional register id.
        /// </summary>
        [MessagePack.Key(8)]
        public int? RegisterId
        {
            get;init;
        }
    }
}
