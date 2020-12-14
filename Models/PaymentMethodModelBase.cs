using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment method.
    /// </summary>
    [DataContract]
    [Serializable]
    public class PaymentMethodModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the payment method.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// The display order of the payment method.
        /// </summary>
        [DataMember]
        [Required]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Whether the payment method is enabled.
        /// </summary>
        [DataMember]
        [Required]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Whether the payment method can be used by manager.
        /// </summary>
        [DataMember]
        [Required]
        public bool IsManager { get; set; }

        /// <summary>
        /// Whether the payment method can be used by clients.
        /// </summary>
        [DataMember]
        [Required]
        public bool IsClient { get; set; }

        /// <summary>
        /// Whether the payment method is deleted.
        /// </summary>
        [DataMember]
        [Required]
        public bool IsDeleted { get; set; }

        #endregion
    }
}