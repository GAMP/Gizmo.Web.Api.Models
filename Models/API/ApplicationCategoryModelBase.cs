using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application category.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationCategoryModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the application category.
        /// </summary>
        [Required]
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// The Id of the parent category if the category is a subcategory, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(1)]
        public int? ParentId { get; set; }

        #endregion
    }
}
