using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User attribute.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class UserAttributeModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the attribute this user attribute is associated with.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(0)]
        public int AttributeId { get; set; }

        /// <summary>
        /// The value of the user attribute.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        [MessagePack.Key(1)]
        public string Value { get; set; }

        #endregion
    }
}
