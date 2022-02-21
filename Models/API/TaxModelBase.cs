using MessagePack;
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
    [MessagePackObject]
    public class TaxModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the tax.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// The value of the tax.
        /// </summary>
        [DataMember]
        [Required]
        [Range(0, 100)]
        [MessagePack.Key(1)]
        public decimal Value { get; set; }

        #endregion
    }
}
