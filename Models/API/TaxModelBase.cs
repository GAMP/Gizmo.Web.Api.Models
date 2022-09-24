using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Tax.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class TaxModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the tax.
        /// </summary>
        [Required]
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// The value of the tax.
        /// </summary>
        [Required]
        [Range(0, 100)]
        [MessagePack.Key(1)]
        public decimal Value { get; set; }

        #endregion
    }
}
