using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host layout group.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class HostLayoutGroupModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the host group.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// The display order of the layout group.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public int DisplayOrder { get; set; }

        #endregion
    }
}