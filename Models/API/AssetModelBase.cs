using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Asset.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class AssetModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the asset type this asset belongs to.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public int AssetTypeId { get; set; }

        /// <summary>
        /// The number of the asset.
        /// </summary>
        [Required]
        [MessagePack.Key(1)]
        public int Number { get; set; }

        /// <summary>
        /// The tag of the asset.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(2)]
        public string Tag { get; set; }

        /// <summary>
        /// The smart card unique id of the asset.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(3)]
        public string SmartCardUid { get; set; }

        /// <summary>
        /// The barcode of the asset.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(4)]
        public string Barcode { get; set; }

        /// <summary>
        /// The serial number of the asset.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(5)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Whether the asset is enabled.
        /// </summary>
        [MessagePack.Key(6)]
        public bool IsEnabled { get; set; }

        #endregion
    }
}