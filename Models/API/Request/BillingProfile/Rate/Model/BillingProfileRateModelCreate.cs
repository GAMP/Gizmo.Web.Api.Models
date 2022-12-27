﻿using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Models.API.Request.BillingProfile.Rate.Model
{
    /// <summary>
    /// Billing profile rate.
    /// </summary>
    [MessagePackObject]
    public sealed class BillingProfileRateModelCreate : IBillingProfileRateApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The start fee of the rate.
        /// </summary>
        [Key(0)]
        public decimal StartFee { get; set; }

        /// <summary>
        /// The minimum fee of the rate.
        /// </summary>
        [Key(1)]
        public decimal MinimumFee { get; set; }

        /// <summary>
        /// The hourly rate of the rate.
        /// </summary>
        [Key(2)]
        public decimal Rate { get; set; }

        /// <summary>
        /// The interval in minutes between the charges.
        /// </summary>
        [Key(3)]
        public int ChargeEvery { get; set; }

        /// <summary>
        /// The number of minutes before the first charge.
        /// </summary>
        [Key(4)]
        public int ChargeAfter { get; set; }

        /// <summary>
        /// Whether the rate is step based.
        /// </summary>
        [Key(5)]
        public bool IsStepBased { get; set; }

        /// <summary>
        /// The steps of the rate.
        /// </summary>
        [Key(6)]
        public IEnumerable<BillingProfileRateStep> RateSteps { get; set; }

        /// <summary>
        /// The days on which the rate is applicable.
        /// </summary>
        [Key(7)]
        public IEnumerable<BillingProfileRateDay> Days { get; set; }

        #endregion
    }
}