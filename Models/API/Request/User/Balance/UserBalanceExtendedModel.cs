namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Extended user balance model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserBalanceExtendedModel : IWebApiModel
    {
        /// <summary>
        /// Gets overall user balance.
        /// </summary>
        [MessagePack.Key(0)]
        public decimal Balance { get; init; }

        /// <summary>
        /// Gets points balance.
        /// </summary>
        [MessagePack.Key(1)]
        public int Points { get; init; }

        /// <summary>
        /// Gets total deposits.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Deposits { get; init; }

        /// <summary>
        /// Gets total time.
        /// </summary>
        [MessagePack.Key(3)]
        public double? Time { get; init; }

        /// <summary>
        /// Gets total credited time.
        /// </summary>
        [MessagePack.Key(4)]
        public double? CreditedTime { get; init; }
    }
}
