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
    public class ProductGroup : EntityBase
    {
        /// <summary>
        /// The name of the product group.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        [DataMember]
        public int? ParentId { get; set; }

        /// <summary>
        /// The display order of the product group.
        /// </summary>
        [DataMember]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// The sort option of the product group.
        /// </summary>
        [DataMember]
        public ProductSortOptionType SortOption { get; set; }

        /// <summary>
        /// The GUID of the product group.
        /// </summary>
        [DataMember]
        public Guid Guid { get; set; }
    }
}