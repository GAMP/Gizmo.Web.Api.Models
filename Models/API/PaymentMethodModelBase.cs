using MessagePack;
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
    [MessagePackObject]
    public class PaymentMethodModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the payment method.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// The display order of the payment method.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Whether the payment method is enabled.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Whether the payment method can be used by manager.
        /// </summary>
        [DataMember]
        [MessagePack.Key(3)]
        public bool AvailableInManager { get; set; }

        /// <summary>
        /// Whether the payment method can be used by clients.
        /// </summary>
        [DataMember]
        [MessagePack.Key(4)]
        public bool AvailableInClient { get; set; }

        /// <summary>
        /// Whether the payment method is deleted.
        /// </summary>
        [DataMember]
        [MessagePack.Key(5)]
        public bool IsDeleted { get; set; }

        #endregion
    }
}