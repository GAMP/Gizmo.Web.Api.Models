using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application category.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationCategoryModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the application category.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// The Id of the parent category if the category is a subcategory, otherwise it will be null.
        /// </summary>
        [DataMember]
        public int? ParentId { get; set; }

        #endregion
    }
}
