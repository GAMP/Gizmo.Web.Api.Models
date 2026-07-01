using System;
using System.Collections.Generic;
using Gizmo.Extensibility.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Describes an available integration type discovered from a loaded plugin module.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class IntegrationTypeModel : IWebApiModel
    {
        /// <summary>
        /// Stable type identifier matching the plugin's <c>[ModuleMetadata]</c> guid.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid TypeGuid { get; init; }

        /// <summary>
        /// Human-readable name of the integration type.
        /// </summary>
        [MessagePack.Key(1)]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Optional human-readable description of the integration type.
        /// Localized server-side against the operator's request culture.
        /// </summary>
        [MessagePack.Key(4)]
        public string? Description { get; init; }

        /// <summary>
        /// Configuration schema sections for this integration type.
        /// Used by the Manager UI to render typed configuration forms.
        /// </summary>
        [MessagePack.Key(2)]
        public IReadOnlyList<ModuleConfigSectionMetadata> ConfigSections { get; init; } = [];

        /// <summary>
        /// Well-known capability GUIDs indicating what functionality this integration supports
        /// (e.g. user authentication, balance handling, session billing).
        /// Used by the Manager UI to filter integrations at configuration points that require
        /// specific capabilities.
        /// </summary>
        [MessagePack.Key(3)]
        public IReadOnlyList<Guid> Capabilities { get; init; } = [];
    }
}
