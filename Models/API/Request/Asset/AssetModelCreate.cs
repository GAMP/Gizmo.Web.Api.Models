#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Asset.
    /// </summary>
    [MessagePackObject]
    public sealed class AssetModelCreate : IAssetApiModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the asset type this asset belongs to.
        /// </summary>
        [MessagePack.Key(0)]
        public int AssetTypeId { get; set; }

        /// <summary>
        /// The number of the asset.
        /// </summary>
        [MessagePack.Key(1)]
        public int Number { get; set; }

        /// <summary>
        /// The tag of the asset.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(2)]
        public string Tag { get; set; } = null!;

        /// <summary>
        /// The smart card unique id of the asset.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(3)]
        public string SmartCardUid { get; set; } = null!;

        /// <summary>
        /// The barcode of the asset.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(4)]
        public string Barcode { get; set; } = null!;

        /// <summary>
        /// The serial number of the asset.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(5)]
        public string SerialNumber { get; set; } = null!;

        /// <summary>
        /// Whether the asset is enabled.
        /// </summary>
        [MessagePack.Key(6)]
        public bool IsEnabled { get; set; }

        #endregion
    }
}