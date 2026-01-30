using Gizmo.Web.Api.Models.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Asset type.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class AssetTypeModelUpdate : IAssetTypeModel, IModelIntIdentifier, IUriParametersQuery
    {
        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The name of the asset type.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The description of the asset type.
        /// </summary>
        [MessagePack.Key(2)]
        public string? Description { get; set; }
    }
}
