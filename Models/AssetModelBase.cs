using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Asset.
    /// </summary>
    [DataContract]
    [Serializable]
    public class AssetModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the asset type this asset belongs to.
        /// </summary>
        [DataMember]
        [Required]
        public int AssetTypeId { get; set; }

        /// <summary>
        /// The number of the asset.
        /// </summary>
        [DataMember]
        [Required]
        public int Number { get; set; }

        /// <summary>
        /// The tag of the asset.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string Tag { get; set; }

        /// <summary>
        /// The smart card unique id of the asset.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string SmartCardUID { get; set; }

        /// <summary>
        /// The barcode of the asset.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string Barcode { get; set; }

        /// <summary>
        /// The serial number of the asset.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Whether the asset is enabled.
        /// </summary>
        [DataMember]
        [Required]
        public bool IsEnabled { get; set; }

        #endregion
    }
}