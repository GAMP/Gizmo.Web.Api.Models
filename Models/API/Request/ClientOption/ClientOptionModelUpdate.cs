using Gizmo.Web.Api.Models.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Client option update model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class ClientOptionModelUpdate : IClientOptionModel, IModelIntIdentifier, IUriParametersQuery
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [StringLength(255)]
        [MessagePack.Key(1)]
        public required string Name { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public bool IsDefault { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public ClientOptionSkinModel? ClientOptionSkin { get; set; }
    }
}
