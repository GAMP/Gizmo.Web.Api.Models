namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc cref="IUserBalanceModel"></inheritdoc>
    [MessagePack.MessagePackObject]
    public sealed class UserBalanceModel : IUserBalanceModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public double? AvailableCreditedTime { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public double? AvailableTime { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public decimal Deposits { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public decimal OnInvoicedUsage { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public decimal OnInvoices { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public decimal OnUninvoicedUsage { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(6)]
        public int Points { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(7)]
        public double TimeFixed { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(8)]
        public double TimeProduct { get; init; }

        /// <inheritdoc/>
        [MessagePack.IgnoreMember()]
        public decimal Balance
        {
            get { return Deposits - OnInvoices - OnUninvoicedUsage; }
        }

        /// <inheritdoc/>
        [MessagePack.IgnoreMember()]
        public double TimeProductBalance
        {
            get { return TimeProduct + TimeFixed; }
        }

        /// <inheritdoc/>
        [MessagePack.IgnoreMember()]
        public decimal UsageBalance
        {
            get { return OnInvoicedUsage + OnUninvoicedUsage; }
        }

        /// <inheritdoc/>
        [MessagePack.IgnoreMember()]
        public decimal TotalOutstanding
        {
            get { return OnInvoices + OnUninvoicedUsage; }
        }
    }
}
