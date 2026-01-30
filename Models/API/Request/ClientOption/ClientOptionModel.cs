using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;
namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Client option.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class ClientOptionModel : IClientOptionModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The name of the client option.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(1)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Skin options model.
        /// </summary>
        [MessagePack.Key(2)]
        public ClientOptionSkinModel? ClientOptionSkin { get; set; }

        /// <summary>
        /// Custom CSS.
        /// </summary>
        [MessagePack.Key(3)]
        public string? CustomCSS { get; set; }

        /// <summary>
        /// Is default flag.
        /// </summary>
        [MessagePack.Key(4)]
        public bool IsDefault { get; set; }

        #endregion
    }
}
