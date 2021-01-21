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
        /// Gets or sets step minute.
        /// </summary>
        [DataMember]
        public int Minute { get; set; }

        /// <summary>
        /// Gets or sets action.
        /// </summary>
        [DataMember]
        public BillingRateStepAction Action { get; set; }

        /// <summary>
        /// Gets or sets charge value.
        /// </summary>
        [DataMember]
        public decimal Charge { get; set; }

        /// <summary>
        /// Gets or sets rate value.
        /// </summary>
        [DataMember]
        public decimal Rate { get; set; }

        /// <summary>
        /// Get or sets target minute.
        /// </summary>
        [DataMember]
        public int TargetMinute { get; set; }

        /// <summary>
        /// Gets or sets billing rate id.
        /// </summary>
        [DataMember]
        [Required()]
        public int BillRateId { get; set; }

        #endregion
    }
}