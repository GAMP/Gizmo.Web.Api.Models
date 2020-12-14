using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product disallowed user group.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ProductDisallowedUserGroupModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the user group.
        /// </summary>
        [DataMember]
        [Required]
        public int UserGroupId { get; set; }

        /// <summary>
        /// Whether this user group is disallowed for this product.
        /// </summary>
        [DataMember]
        [Required]
        public bool IsDisallowed { get; set; }

        #endregion
    }
}