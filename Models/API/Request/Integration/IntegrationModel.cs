using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Integration model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class IntegrationModel : IWebApiModel
    {
        /// <summary>
        /// Integration id.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Human-readable display name.
        /// </summary>
        [MessagePack.Key(1)]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Integration type guid. Matches the plugin's <c>[ModuleMetadata]</c> guid.
        /// Constant across installations of the same plugin type.
        /// </summary>
        [MessagePack.Key(2)]
        public Guid TypeGuid { get; init; }

        /// <summary>
        /// Per-installation stable public identity.
        /// Used as the keying value for DI registrations and data directories.
        /// </summary>
        [MessagePack.Key(3)]
        public Guid PublicId { get; init; }

        /// <summary>
        /// Raw configuration JSON stored for this integration, or <see langword="null"/>
        /// if no configuration has been saved yet.
        /// </summary>
        [MessagePack.Key(4)]
        public string? ConfigJson { get; init; }

        /// <summary>
        /// Current configuration schema version.
        /// </summary>
        [MessagePack.Key(5)]
        public int? ConfigSchemaVersion { get; init; }

        /// <summary>
        /// Indicates whether the integration is disabled.
        /// </summary>
        [MessagePack.Key(6)]
        public bool IsDisabled { get; init; }
    }
}
