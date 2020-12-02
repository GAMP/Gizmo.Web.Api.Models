using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Attribute.
    /// </summary>
    [DataContract]
    [Serializable]
    public class AttributeModelBase : IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the attribute.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// The friendly name of the product.
        /// </summary>
        [DataMember]
        [StringLength(45)]
        public string FriendlyName { get; set; }

        #endregion
    }
}