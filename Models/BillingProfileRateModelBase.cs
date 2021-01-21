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
        /// Gets
        /// </summary>
        [DataMember]
        public decimal StartFee { get; set; }

        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        public decimal MinimumFee { get; set; }

        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        public decimal Rate { get; set; }

        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        public int ChargeEvery { get; set; }

        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        public int ChargeAfter { get; set; }

        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        public BillingRateOptionType RateOptions { get; set; }

        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        public IEnumerable<BillingProfileRateStep> RateSteps { get; set; }

        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        public IEnumerable<BillingProfileRateDay> Days { get; set; }

    }
}