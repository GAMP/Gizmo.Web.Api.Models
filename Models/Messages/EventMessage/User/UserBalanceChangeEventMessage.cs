namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User balance changed event message.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserBalanceChangeEventMessage : UserEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserBalanceChangeEventMessage() : base()
        { }

        /// <summary>
        /// Balance.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Balance { get; init; }

        /// <summary>
        /// Deposit balance.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal Deposits { get; init; }

        /// <summary>
        /// Time balance.
        /// </summary>
        [MessagePack.Key(4)]
        public int? Time { get; init;}

        /// <summary>
        /// Points balance.
        /// </summary>
        [MessagePack.Key(5)]
        public int Points { get; init;}
    }
}
