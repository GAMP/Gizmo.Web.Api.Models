using System.Collections.Generic;
using Gizmo.Extensibility.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Describes a custom parameter an achievement signal accepts, used by configuration
    /// editors to generate parameter input UI.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class AchievementSignalParameterModel : IWebApiModel
    {
        /// <summary>
        /// Stable parameter key (e.g. <c>game.wins</c>). Achievement configuration stores
        /// parameter values under this key.
        /// </summary>
        [MessagePack.Key(0)]
        public string Key { get; init; } = string.Empty;

        /// <summary>
        /// Kind of value the parameter accepts — drives the input control and validation.
        /// </summary>
        [MessagePack.Key(1)]
        public SignalParameterKind Kind { get; init; }

        /// <summary>
        /// Human-readable parameter name, localized server-side against the operator's request culture.
        /// </summary>
        [MessagePack.Key(2)]
        public string DisplayName { get; init; } = string.Empty;

        /// <summary>
        /// Optional human-readable parameter description, localized server-side.
        /// </summary>
        [MessagePack.Key(3)]
        public string? Description { get; init; }

        /// <summary>
        /// Indicates the parameter must be provided when configuring an achievement on this signal.
        /// </summary>
        [MessagePack.Key(4)]
        public bool IsRequired { get; init; }

        /// <summary>
        /// Optional default value pre-filled by editors.
        /// </summary>
        [MessagePack.Key(5)]
        public string? DefaultValue { get; init; }

        /// <summary>
        /// Optional closed set of allowed values. When present, editors render a selection
        /// control instead of a free input.
        /// </summary>
        [MessagePack.Key(6)]
        public IReadOnlyList<AchievementSignalParameterValueModel>? AllowedValues { get; init; }
    }

    /// <summary>
    /// A single allowed value of a custom signal parameter.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class AchievementSignalParameterValueModel : IWebApiModel
    {
        /// <summary>
        /// The value stored in achievement configuration when selected.
        /// </summary>
        [MessagePack.Key(0)]
        public string Value { get; init; } = string.Empty;

        /// <summary>
        /// Human-readable value name, localized server-side.
        /// </summary>
        [MessagePack.Key(1)]
        public string DisplayName { get; init; } = string.Empty;
    }
}
