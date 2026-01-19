using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Metadata describing a single option entry.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class LicensePluginPropertyMetadataModel : IWebApiModel
    {
        /// <summary>
        /// Gets option name.
        /// </summary>
        [MessagePack.Key(0)]
        public string? Name { get; init; }

        /// <summary>
        /// Gets option description.
        /// </summary>
        [MessagePack.Key(1)]
        public string? Description
        {
            get;
            init;
        }

        /// <summary>
        /// Gets option value type full name.
        /// </summary>
        [MessagePack.Key(2)]
        public required string ValueTypeName { get; init; }

        /// <summary>
        /// Gets value property name.
        /// </summary>
        [MessagePack.Key(3)]
        public required string ValuePropertyName { get; init; }

        /// <summary>
        /// Optional default value.
        /// </summary>
        [MessagePack.Key(4)]
        public string? DefaultValue { get; init; } = null;

        /// <summary>
        /// Allowed values for the option (if applicable).
        /// </summary>
        [MessagePack.Key(5)]
        public required IEnumerable<LicensePluginPropertyAllowedValueMetadata> AllowedValues { get; init; } = Enumerable.Empty<LicensePluginPropertyAllowedValueMetadata>();
    } 
}
