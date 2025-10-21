using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment intent type.
    /// </summary>
    /// <remarks>
    /// The flag is used to represent multiple intent types in a single value.
    /// </remarks>
    [Flags]
    public enum PaymentIntentType
    {
        /// <summary>
        /// Deposit.
        /// </summary>
        Deposit = 1,

        /// <summary>
        /// Order.
        /// </summary>
        Order = 2,

        /// <summary>
        /// Invoice.
        /// </summary>
        Invoice = 4
    }
}
