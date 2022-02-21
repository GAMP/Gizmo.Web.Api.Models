using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product hidden host group.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ProductHiddenHostGroupModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the host group.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(0)]
        public int HostGroupId { get; set; }

        /// <summary>
        /// Whether this product is hidden in this host group.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public bool IsHidden { get; set; }

        #endregion
    }
}
