using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product disallowed user group.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductDisallowedUserGroupModelUpdate : ProductDisallowedUserGroupModelBase, IEntityBase, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Required]
        [MessagePack.Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the product.
        /// </summary>
        [Required]
        [MessagePack.Key(101)]
        public int ProductId { get; set; }

        #endregion
    }
}