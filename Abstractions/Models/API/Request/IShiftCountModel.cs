namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Shift count.
    /// </summary>
    public interface IShiftCountModel
    {
        /// <summary>
        /// Actual.
        /// </summary>
        decimal Actual { get; init; }

        /// <summary>
        /// Deposits.
        /// </summary>
        decimal Deposits { get; init; }

        /// <summary>
        /// Difference.
        /// </summary>
        decimal Difference { get; init; }

        /// <summary>
        /// Expected.
        /// </summary>
        decimal Expected { get; init; }

        /// <summary>
        /// Note.
        /// </summary>
        string? Note { get; init; }

        /// <summary>
        /// Pay ins.
        /// </summary>
        decimal PayIns { get; init; }

        /// <summary>
        /// Payment method id.
        /// </summary>
        int PaymentMethodId { get; init; }

        /// <summary>
        /// Pay outs.
        /// </summary>
        decimal PayOuts { get; init; }

        /// <summary>
        /// Reffuns.
        /// </summary>
        decimal Refunds { get; init; }

        /// <summary>
        /// Sales.
        /// </summary>
        decimal Sales { get; init; }

        /// <summary>
        /// Shift id.
        /// </summary>
        int ShiftId { get; init; }

        /// <summary>
        /// Start cash.
        /// </summary>
        decimal StartCash { get; init; }

        /// <summary>
        /// Voids.
        /// </summary>
        decimal Voids { get; init; }

        /// <summary>
        /// Withdrawals.
        /// </summary>
        decimal Withdrawals { get; init; }
    }
}
