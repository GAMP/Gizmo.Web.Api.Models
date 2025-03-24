using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Client option.
    /// </summary>
    [MessagePackObject]
    public sealed class ClientOptionModelCreate : IClientOptionModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the client option.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(0)]
        public string Name { get; set; } = null!;

        [MessagePack.Key(1)]
        public ClientOptionSkinModel? ClientOptionSkin { get; set; }

        #endregion
    }
}
