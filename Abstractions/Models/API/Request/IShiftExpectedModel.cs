using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Shift expected model.
    /// </summary>
    public interface IShiftExpectedModel : IWebApiModel
    {
        /// <summary>
        /// Expected amounts.
        /// </summary>
        IEnumerable<ShiftExpectedTransactionModel> Exepected { get; init; }

        /// <summary>
        /// Total expected amount.
        /// </summary>
        decimal ExpectedTotal { get; init; }
    }
}
