using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Asset type.
    /// </summary>
    [MessagePackObject]
    public sealed class AssetTypeModelUpdate : IAssetTypeApiModel, IApiModelIdentifier, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The name of the asset type.
        /// </summary>
        [MessagePack.Key(1)]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the asset type.
        /// </summary>
        [MessagePack.Key(2)]
        public string Description { get; set; }

        #endregion
    }
}