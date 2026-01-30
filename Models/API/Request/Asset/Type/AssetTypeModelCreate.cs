using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Asset type.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class AssetTypeModelCreate : IAssetTypeModel, IUriParametersQuery
    {
        /// <summary>
        /// The name of the asset type.
        /// </summary>
        [MessagePack.Key(0)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The description of the asset type.
        /// </summary>
        [MessagePack.Key(1)]
        public string? Description { get; set; }
    }
}
