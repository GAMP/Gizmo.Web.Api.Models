using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment intent model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class PaymentIntentModel : IWebApiModel
    {
        /// <summary>
        /// Payment intent id.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Payment method id.
        /// </summary>
        [MessagePack.Key(1)]
        public int PaymentMethodId { get; init; }

        /// <summary>
        /// Amount.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Amount { get; init; }

        /// <summary>
        /// Payment intent state.
        /// </summary>
        [MessagePack.Key(3)]
        public PaymentIntentState State { get; init; }

        /// <summary>
        /// Transaction id.
        /// </summary>  
        /// <remarks>
        /// This will only have a value if the payment intent has been completed successfully.
        /// </remarks>
        [MessagePack.Key(4)]
        public string? TransactionId { get; init; }

        /// <summary>
        /// Transaction time.
        /// </summary>
        /// <remarks>
        /// This will only have a value if the payment intent has been completed successfully.
        /// </remarks>
        [MessagePack.Key(5)]
        public DateTime? TransactionTime { get; init; }

        /// <summary>
        /// Payment provider.
        /// </summary>
        [MessagePack.Key(6)]
        public Guid Provider { get; init; }

        /// <summary>
        /// Payment intent unique identifier.
        ///</summary>
        [MessagePack.Key(7)]
        public Guid Identifier { get; init; }

        /// <summary>
        /// Branch id.
        /// </summary>
        [MessagePack.Key(8)]
        public int? BranchId { get; init; }

        /// <summary>
        /// Payment url.
        /// </summary>
        [MessagePack.Key(9)]
        public string? PaymentUrl { get; init; }


        /// <summary>
        /// Expiration in minutes.
        /// </summary>
        [MessagePack.Key(10)]
        public int? Expiration { get; init; }

        /// <summary>
        /// Precalculated expiration time.
        /// </summary>
        [MessagePack.Key(11)]
        public DateTime? ExpireAt { get; init; }

        /// <summary>
        /// Payment id.
        /// </summary>
        /// <remarks>
        /// This will only have a value if the payment intent has been completed successfully.
        /// </remarks>
        [MessagePack.Key(12)]
        public int? PaymentId { get; init; }

        /// <summary>
        /// Created by user id.
        /// </summary>
        /// <remarks>
        /// This value may be null if created by system and can represent both operators and member users.
        /// </remarks>
        [MessagePack.Key(13)]
        public int? CreatedById { get; init; }

        /// <summary>
        /// Created time.
        /// </summary>
        [MessagePack.Key(14)]
        public DateTime CreatedTime { get; init; }

        /// <summary>
        /// Modified by user id.
        /// </summary>
        /// <remarks>
        /// This value may be null if created by system and can represent both operators and member users.
        /// </remarks>
        [MessagePack.Key(15)]
        public int? ModifiedById { get; init; }

        ///<summary>
        /// Modified time.
        /// </summary>
        [MessagePack.Key(16)]
        public DateTime? ModifiedTime { get; init; }

        /// <summary>
        /// Payment intent type.
        /// </summary>
        [MessagePack.Key(17)]
        public PaymentIntentType Type { get; init; }
    }
}
