using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User attribute.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class UserAttributeModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the attribute this user attribute is associated with.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public int AttributeId { get; set; }

        /// <summary>
        /// The value of the user attribute.
        /// </summary>
        [Required]
        [StringLength(255)]
        [MessagePack.Key(1)]
        public string Value { get; set; }

        #endregion
    }
}
