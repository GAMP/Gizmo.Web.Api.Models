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
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Whether the payment method is enabled.
        /// </summary>
        [DataMember]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Whether the payment method can be used by manager.
        /// </summary>
        [DataMember]
        public bool AvailableInManager { get; set; }

        /// <summary>
        /// Whether the payment method can be used by clients.
        /// </summary>
        [DataMember]
        public bool AvailableInClient { get; set; }

        /// <summary>
        /// Whether the payment method is deleted.
        /// </summary>
        [DataMember]
        public bool IsDeleted { get; set; }

        #endregion
    }
}