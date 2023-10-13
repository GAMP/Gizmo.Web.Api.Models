namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// <inheritdoc cref="IShiftExpectedTransactionModel"/>
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ShiftExpectedTransactionModel : IShiftExpectedTransactionModel
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        public int PaymentMethodId
        {
            get; init;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(1)]
        public decimal Amount
        {
            get; init;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(2)]
        public int Count
        {
            get; init;
        }
    }
}
