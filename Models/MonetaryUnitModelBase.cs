using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Monetary unit.
    /// </summary>
    [DataContract]
    [Serializable]
    public class MonetaryUnitModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the monetary unit.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// The value of the monetary unit.
        /// </summary>
        [DataMember]
        [Required]
        public decimal Value { get; set; }

        /// <summary>
        /// The display order of the monetary unit.
        /// </summary>
        [DataMember]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Whether the monetary unit is deleted.
        /// </summary>
        [DataMember]
        public bool IsDeleted { get; set; }

        #endregion
    }
}