using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time billing options.
    /// </summary>
    [Flags()]
    public enum BillingOption
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,
        /// <summary>
        /// Disable time offers.
        /// </summary>
        DisableTimeOffer = 1,
        /// <summary>
        /// Disable fixed time.
        /// </summary>
        DisableFixedTime = 2,
        /// <summary>
        /// Disable deposits.
        /// </summary>
        DisableDeposit = 4,
    }
}
