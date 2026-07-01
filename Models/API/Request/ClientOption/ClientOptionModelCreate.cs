using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Client option create model.
    /// </summary>
    [MessagePackObject]
    public sealed class ClientOptionModelCreate : IClientOptionModel, IUriParametersQuery
    {
        /// <inheritdoc/>
        [StringLength(255)]
        [MessagePack.Key(0)]
        public required string Name { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public bool IsDefault { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public ClientOptionSkinModel? ClientOptionSkin { get; set; }
    }
}
