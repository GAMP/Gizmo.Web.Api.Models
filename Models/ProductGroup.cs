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
    public class ProductGroup : EntityBase , IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the product group.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        [MessagePack.Key(1)]
        public string Name { get; set; }

        /// <summary>
        /// The display order of the product group.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// The sort option of the product group.
        /// </summary>
        [DataMember]
        [MessagePack.Key(3)]
        public ProductSortOptionType SortOption { get; set; }

        /// <summary>
        /// The GUID of the product group.
        /// </summary>
        [DataMember]
        [MessagePack.Key(4)]
        public Guid Guid { get; set; }

        #endregion
    }
}
