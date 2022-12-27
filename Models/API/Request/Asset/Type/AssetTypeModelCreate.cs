using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Asset.Type
{
    /// <summary>
    /// Asset type.
    /// </summary>
    [MessagePackObject]
    public sealed class AssetTypeModelCreate : IAssetTypeApiModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the asset type.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the asset type.
        /// </summary>
        [MessagePack.Key(1)]
        public string Description { get; set; }

        #endregion
    }
}