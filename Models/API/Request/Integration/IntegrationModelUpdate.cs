using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Integration update model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class IntegrationModelUpdate : IWebApiModel
    {
        /// <summary>
        /// Human-readable display name.
        /// </summary>
        [Required]
        [StringLength(255)]
        [MessagePack.Key(0)]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Whether the integration should be disabled.
        /// </summary>
        [MessagePack.Key(1)]
        public bool IsDisabled { get; init; }
    }
}
