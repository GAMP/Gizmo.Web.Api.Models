using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Shift expected model.
    /// </summary>
    public interface IShiftExpectedModel : IWebApiModel
    {
        /// <summary>
        /// Payments.
        /// </summary>
        IEnumerable<ShiftExpectedTransactionModel> Payments { get; init; }

        /// <summary>
        /// Refunds.
        /// </summary>
        IEnumerable<ShiftExpectedTransactionModel> Refunds { get; }

        /// <summary>
        /// Deposits.
        /// </summary>
        IEnumerable<ShiftExpectedTransactionModel> Deposits { get; }

        /// <summary>
        /// Withdrawals.
        /// </summary>
        IEnumerable<ShiftExpectedTransactionModel> Withdrawals { get; }

        /// <summary>
        /// Total expected amount.
        /// </summary>
        decimal Expected { get; init; }
    }
}
