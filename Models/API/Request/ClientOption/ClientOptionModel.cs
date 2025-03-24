using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Client option.
    /// </summary>
    [MessagePackObject]
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

        [MessagePack.Key(2)]
        public ClientOptionSkinModel? ClientOptionSkin { get; set; }

        #endregion
    }
}
