using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Integration create model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class IntegrationModelCreate : IWebApiModel
    {
        /// <summary>
        /// Human-readable display name.
        /// </summary>
        [Required]
        [StringLength(255)]
        [MessagePack.Key(0)]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Integration type guid. Must match a loaded plugin's <c>[ModuleMetadata]</c> guid.
        /// </summary>
        [MessagePack.Key(1)]
        public Guid TypeGuid { get; init; }

        /// <summary>
        /// Initial configuration JSON, or <see langword="null"/> to use defaults.
        /// </summary>
        [MessagePack.Key(2)]
        public string? ConfigJson { get; init; }

        /// <summary>
        /// Initial configuration schema version.
        /// </summary>
        [MessagePack.Key(3)]
        public int? ConfigSchemaVersion { get; init; }
    }
}
