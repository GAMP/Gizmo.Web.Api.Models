using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment intent.
    /// </summary>
    [MessagePackObject]
    public class PaymentIntentModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The date that the payment intent was created.
        /// </summary>
        [MessagePack.Key(0)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the user this payment intent is associated with.
        /// </summary>
        [MessagePack.Key(1)]
        public int UserId { get; set; }

        /// <summary>
        /// The Id of the payment method this payment intent is associated with.
        /// </summary>
        [MessagePack.Key(2)]
        public int PaymentMethodId { get; set; }

        /// <summary>
        /// The amount of the payment intent.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The state of the payment intent.
        /// </summary>
        [MessagePack.Key(4)]
        public PaymentIntentState State { get; set; }

        [MessagePack.Key(5)]
        public string TransactionId { get; set; }

        [MessagePack.Key(6)]
        public DateTime? TransactionTime { get; set; }

        /// <summary>
        /// The GUID of the provider this payment intent is associated with.
        /// </summary>
        [MessagePack.Key(7)]
        public Guid Provider { get; set; }

        #endregion
    }
}
