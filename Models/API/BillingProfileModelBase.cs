using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Billing profile.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class BillingProfileModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the billing profile.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// The default rate of the billing profile.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(1)]
        public BillingProfileRateModelBase DefaultRate { get; set; }

        #endregion
    }
}