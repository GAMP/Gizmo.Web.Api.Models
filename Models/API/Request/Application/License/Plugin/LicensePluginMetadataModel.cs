using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// License plugin metadata model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class LicensePluginMetadataModel : IWebApiModel
    {
        /// <summary>
        /// Plugin unique identifier.
        /// </summary>
        [MessagePack.Key(0)]
        public required Guid Guid { get; init; }

        /// <summary>
        /// Plugin assembly name.
        /// </summary>
        [MessagePack.Key(1)]
        public required string Assembly { get; init; }

        /// <summary>
        /// Plugin type.
        /// </summary>
        [MessagePack.Key(2)]
        public required string Type { get; init; }

        /// <summary>
        /// Options metadata.
        /// </summary>
        [MessagePack.Key(3)]
        public required IEnumerable<LicensePluginPropertyMetadataModel> Options { get; set; }

        /// <summary>
        /// Key metadata.
        /// </summary>
        [MessagePack.Key(4)]
        public required IEnumerable<LicensePluginPropertyMetadataModel> KeyOptions { get; set; }

        /// <summary>
        /// Gets plugin name.
        /// </summary>
        [MessagePack.Key(5)]
        public required string Name { get; init; }

        /// <summary>
        /// Gets plugin description.
        /// </summary>
        [MessagePack.Key(6)]
        public string? Description { get; init; }

        /// <summary>
        /// Plugin icon data.
        /// </summary>
        [MessagePack.Key(7)]
        public byte[]? IconData { get; init; }

        /// <summary>
        /// Indicates whether the plugin is deprecated.
        /// </summary>
        [MessagePack.Key(8)]
        public bool IsDeprecated { get; set; }
    }
}
