using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Attribute.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class AttributeModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the attribute.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// The friendly name of the attribute.
        /// </summary>
        [DataMember]
        [StringLength(45)]
        [MessagePack.Key(1)]
        public string FriendlyName { get; set; }

        #endregion
    }
}