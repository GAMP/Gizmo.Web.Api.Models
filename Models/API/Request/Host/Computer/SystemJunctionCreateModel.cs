using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Junction creation model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class SystemJunctionCreateModel : IWebApiModel
    {
        /// <summary>
        /// Junction link.
        /// </summary>
        [Required()]
        [MessagePack.Key(0)]
        public string Link { get; init; } = null!;

        /// <summary>
        /// Junction target.
        /// </summary>
        [Required()]
        [MessagePack.Key(1)]
        public string Target { get; init; } = null!;

        /// <summary>
        /// Delete existing links.
        /// </summary>
        /// <remarks>
        /// Forces deletion of existing links.<br></br>
        /// This ensures that if link exists already it will point to the new <see cref="Target"/> directory.
        /// </remarks>
        [MessagePack.Key(2)]
        public bool DeleteExistingLinks { get; init; }
    }
}
