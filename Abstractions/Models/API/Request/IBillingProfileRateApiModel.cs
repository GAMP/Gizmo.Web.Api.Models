using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Billing profile rate.
    /// </summary>
    public interface IBillingProfileRateApiModel
    {
        /// <summary>
        /// The number of minutes before the first charge.
        /// </summary>
        int ChargeAfter { get; set; }

        /// <summary>
        /// The interval in minutes between the charges.
        /// </summary>
        int ChargeEvery { get; set; }

        /// <summary>
        /// The days on which the rate is applicable.
        /// </summary>
        IEnumerable<BillingProfileRateDay> Days { get; set; }

        /// <summary>
        /// Whether the rate is step based.
        /// </summary>
        bool IsStepBased { get; set; }

        /// <summary>
        /// The minimum fee of the rate.
        /// </summary>
        decimal MinimumFee { get; set; }

        /// <summary>
        /// The hourly rate of the rate.
        /// </summary>
        decimal Rate { get; set; }

        /// <summary>
        /// The steps of the rate.
        /// </summary>
        IEnumerable<BillingProfileRateStep> RateSteps { get; set; }

        /// <summary>
        /// The start fee of the rate.
        /// </summary>
        decimal StartFee { get; set; }
    }
}