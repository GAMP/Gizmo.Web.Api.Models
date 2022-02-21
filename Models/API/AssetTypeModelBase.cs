using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Asset type.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class AssetTypeModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the asset type.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the asset type.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public string Description { get; set; }

        #endregion
    }
}