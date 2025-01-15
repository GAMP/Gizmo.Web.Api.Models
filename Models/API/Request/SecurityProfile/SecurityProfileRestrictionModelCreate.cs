using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Security profile restriction create model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class SecurityProfileRestrictionModelCreate : IWebApiModel
    {
        /// <summary>
        /// Type.
        /// </summary>
        [MessagePack.Key(0)]
        public int Type { get; init; }

        /// <summary>
        /// Value.
        /// </summary>
        [StringLength(255)]
        [Required()]
        [MessagePack.Key(0)]
        public string Value { get; init; } = null!;
    }
}
