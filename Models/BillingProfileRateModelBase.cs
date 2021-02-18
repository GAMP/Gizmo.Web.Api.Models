using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Billing profile rate.
    /// </summary>
    [DataContract]
    [Serializable]
    public class BillingProfileRateModelBase
    {
        /// <summary>
        /// The start fee of the rate.
        /// </summary>
        [DataMember]
        public decimal StartFee { get; set; }

        /// <summary>
        /// The minimum fee of the rate.
        /// </summary>
        [DataMember]
        public decimal MinimumFee { get; set; }

        /// <summary>
        /// The hourly rate of the rate.
        /// </summary>
        [DataMember]
        public decimal Rate { get; set; }

        /// <summary>
        /// The interval in minutes between the charges.
        /// </summary>
        [DataMember]
        public int ChargeEvery { get; set; }

        /// <summary>
        /// The number of minutes before the first charge.
        /// </summary>
        [DataMember]
        public int ChargeAfter { get; set; }

        /// <summary>
        /// Whether the rate is the default rate of the billing profile.
        /// </summary>
        [DataMember]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Whether the rate is step based.
        /// </summary>
        [DataMember]
        public bool IsStepBased { get; set; }

        /// <summary>
        /// The steps of the rate.
        /// </summary>
        [DataMember]
        public IEnumerable<BillingProfileRateStep> RateSteps { get; set; }

        /// <summary>
        /// The days on which the rate is applicable.
        /// </summary>
        [DataMember]
        public IEnumerable<BillingProfileRateDay> Days { get; set; }

    }
}