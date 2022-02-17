using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Billing profile rate step.
    /// </summary>
    [DataContract]
    [Serializable]
    public class BillingProfileRateStep
    {
        #region PROPERTIES

        /// <summary>
        /// The minute of the rate step.
        /// </summary>
        [DataMember]
        public int Minute { get; set; }

        /// <summary>
        /// The action of the rate step.
        /// </summary>
        [DataMember]
        [EnumValue]
        public BillingRateStepAction Action { get; set; }

        /// <summary>
        /// The charge value of the rate step.
        /// </summary>
        [DataMember]
        public decimal Charge { get; set; }

        /// <summary>
        /// The rate value of the rate step.
        /// </summary>
        [DataMember]
        public decimal Rate { get; set; }

        /// <summary>
        /// The target minute of the rate step.
        /// </summary>
        [DataMember]
        public int TargetMinute { get; set; }

        #endregion
    }
}