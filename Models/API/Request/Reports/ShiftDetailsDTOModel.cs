namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Shift Details.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ShiftDetailsDTOModel
    {
        /// <summary>
        /// Payment method name.
        /// </summary>
        [MessagePack.Key(0)]
        public string? PaymentMethodName { get; set; }

        /// <summary>
        /// Cash amount the shift started with for this payment method.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal StartCash { get; set; }

        /// <summary>
        /// Total amount of sales in this shift for this payment method.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Sales { get; set; }

        /// <summary>
        /// Total amount of deposits in this shift for this payment method.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal Deposits { get; set; }

        /// <summary>
        /// Total amount of withdrawals in this shift for this payment method.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal Withdrawals { get; set; }

        /// <summary>
        /// Total amount of refunds in this shift for this payment method.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal Refunds { get; set; }

        /// <summary>
        /// Total amount of pay ins in this shift for this payment method.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal PayIns { get; set; }

        /// <summary>
        /// Total amount of pay outs in this shift for this payment method.
        /// </summary>
        [MessagePack.Key(7)]
        public decimal PayOuts { get; set; }

        /// <summary>
        /// Amount expected the shift to end with for this payment method.
        /// </summary>
        [MessagePack.Key(8)]
        public decimal Expected { get; set; }

        /// <summary>
        /// Actual amount the shift ended with for this payment method.
        /// </summary>
        [MessagePack.Key(9)]
        public decimal Actual { get; set; }

        /// <summary>
        /// Difference between the expected and the actual amount for this payment method.
        /// </summary>
        [MessagePack.Key(10)]
        public decimal Difference { get; set; }

    }
}
