using MessagePack;
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
    [MessagePackObject]
    public class BillingProfileRateModelBase
    {
        /// <summary>
        /// The start fee of the rate.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public decimal StartFee { get; set; }

        /// <summary>
        /// The minimum fee of the rate.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public decimal MinimumFee { get; set; }

        /// <summary>
        /// The hourly rate of the rate.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public decimal Rate { get; set; }

        /// <summary>
        /// The interval in minutes between the charges.
        /// </summary>
        [DataMember]
        [MessagePack.Key(3)]
        public int ChargeEvery { get; set; }

        /// <summary>
        /// The number of minutes before the first charge.
        /// </summary>
        [DataMember]
        [MessagePack.Key(4)]
        public int ChargeAfter { get; set; }

        /// <summary>
        /// Whether the rate is step based.
        /// </summary>
        [DataMember]
        [MessagePack.Key(5)]
        public bool IsStepBased { get; set; }

        /// <summary>
        /// The steps of the rate.
        /// </summary>
        [DataMember]
        [MessagePack.Key(6)]
        public IEnumerable<BillingProfileRateStep> RateSteps { get; set; }

        /// <summary>
        /// The days on which the rate is applicable.
        /// </summary>
        [DataMember]
        [MessagePack.Key(7)]
        public IEnumerable<BillingProfileRateDay> Days { get; set; }

    }
}