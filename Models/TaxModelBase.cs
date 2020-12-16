using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Tax.
    /// </summary>
    [DataContract]
    [Serializable]
    public class TaxModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the tax.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// The value of the tax.
        /// </summary>
        [DataMember]
        public decimal Value { get; set; }

        #endregion
    }
}
