using MessagePack;
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
    [MessagePackObject]
    public class ProductDisallowedUserGroupModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the user group.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(0)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// Whether this user group is disallowed for this product.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public bool IsDisallowed { get; set; }

        #endregion
    }
}