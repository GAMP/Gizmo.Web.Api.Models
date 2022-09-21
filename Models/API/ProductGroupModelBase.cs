using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product group.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ProductGroupModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the product group.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// The display order of the product group.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// The sort option of the product group.
        /// </summary>
        [DataMember]
        [Required]
        [EnumValueValidation]
        [MessagePack.Key(2)]
        public ProductSortOptionType SortOption { get; set; }

        #endregion
    }
}
