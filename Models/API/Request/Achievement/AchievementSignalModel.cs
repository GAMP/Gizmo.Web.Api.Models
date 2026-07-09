using System;
using Gizmo.Extensibility.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Describes an achievement signal available for achievement configuration.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class AchievementSignalModel : IWebApiModel
    {
        /// <summary>
        /// Stable unique signal identity. Achievement configuration references signals by this value.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid SignalGuid { get; init; }

        /// <summary>
        /// Human-readable signal name, localized server-side against the operator's request culture.
        /// </summary>
        [MessagePack.Key(1)]
        public string DisplayName { get; init; } = string.Empty;

        /// <summary>
        /// Native measurement unit of the signal values.
        /// </summary>
        [MessagePack.Key(2)]
        public SignalUnit Unit { get; init; }

        /// <summary>
        /// Optional human-readable signal description, localized server-side against
        /// the operator's request culture.
        /// </summary>
        [MessagePack.Key(3)]
        public string? Description { get; init; }

        /// <summary>
        /// Query filter kinds the signal supports for achievement requirements.
        /// </summary>
        [MessagePack.Key(4)]
        public SignalFilterKinds SupportedFilters { get; init; }

        /// <summary>
        /// Custom parameters the signal accepts, localized server-side against the operator's
        /// request culture. Null when the signal accepts no custom parameters.
        /// </summary>
        [MessagePack.Key(5)]
        public System.Collections.Generic.IReadOnlyList<AchievementSignalParameterModel>? Parameters { get; init; }
    }
}
