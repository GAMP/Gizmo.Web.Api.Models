using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ShiftExpectedModel : IShiftExpectedModel
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<ShiftExpectedTransactionModel> Payments { get; init; } = Enumerable.Empty<ShiftExpectedTransactionModel>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<ShiftExpectedTransactionModel> Refunds { get; init; } = Enumerable.Empty<ShiftExpectedTransactionModel>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(2)]
        public IEnumerable<ShiftExpectedTransactionModel> Deposits { get; init; } = Enumerable.Empty<ShiftExpectedTransactionModel>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(3)]
        public IEnumerable<ShiftExpectedTransactionModel> Withdrawals { get; init; } = Enumerable.Empty<ShiftExpectedTransactionModel>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(4)]
        public decimal Expected { get; init; }
    }
}
