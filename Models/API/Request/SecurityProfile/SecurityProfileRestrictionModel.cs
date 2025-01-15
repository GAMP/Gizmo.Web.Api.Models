using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Security profile restriction model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class SecurityProfileRestrictionModel : IWebApiModel , IModelIntIdentifier
    {
        /// <summary>
        /// Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Type.
        /// </summary>
        [MessagePack.Key(1)]
        public int Type { get; init; }

        /// <summary>
        /// Value.
        /// </summary>
        [StringLength(255)]
        [Required()]
        [MessagePack.Key(2)]
        public string Value { get; init; } = null!;
    }
}
