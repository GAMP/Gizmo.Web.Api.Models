namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User balance changed event message.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserBalanceChangedEventMessage : UserEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserBalanceChangedEventMessage() : base()
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
        public double? Time
        {
            get;init;
        }

        /// <summary>
        /// Credited time balance.
        /// </summary>
        [MessagePack.Key(5)]
        public double? CreditedTime { get; init;}

        /// <summary>
        /// Points balance.
        /// </summary>
        [MessagePack.Key(6)]
        public int Points { get; init;}
    }
}
