using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// One achievement in a user's achievements view — the catalog facts plus the user's
    /// lifetime and current-instance standing on it.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserAchievementModel : IWebApiModel
    {
        /// <summary>
        /// Achievement id.
        /// </summary>
        [MessagePack.Key(0)]
        public int AchievementId { get; init; }

        /// <summary>
        /// The achievement's display name.
        /// </summary>
        [MessagePack.Key(1)]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Customer-facing description.
        /// </summary>
        [MessagePack.Key(2)]
        public string? Description { get; init; }

        /// <summary>
        /// Badge image guid, servable directly from the files endpoint; null when the
        /// achievement has no image.
        /// </summary>
        [MessagePack.Key(3)]
        public Guid? ImageGuid { get; init; }

        /// <summary>
        /// The identity of the signal the achievement measures — the signals list carries its
        /// display name and unit label.
        /// </summary>
        [MessagePack.Key(4)]
        public Guid SignalGuid { get; init; }

        /// <summary>
        /// The measurement unit of <see cref="CurrentValue"/> and <see cref="TargetValue"/> —
        /// drives their display formatting. Null when the signal has no registered provider.
        /// </summary>
        [MessagePack.Key(5)]
        public SignalUnit? Unit { get; init; }

        /// <summary>
        /// The calendar range one completion is evaluated within.
        /// </summary>
        [MessagePack.Key(6)]
        public CalendarPeriod Range { get; init; }

        /// <summary>
        /// The achievement's target value per completion, in the signal's native unit.
        /// </summary>
        [MessagePack.Key(7)]
        public decimal TargetValue { get; init; }

        /// <summary>
        /// Maximum completions within one range instance.
        /// </summary>
        [MessagePack.Key(8)]
        public int MaxCompletionsPerRange { get; init; }

        /// <summary>
        /// Hidden from customers — listed only because the user has completions on it.
        /// </summary>
        [MessagePack.Key(9)]
        public bool IsHidden { get; init; }

        /// <summary>
        /// The achievement's state for this user, computed on the server.
        /// </summary>
        [MessagePack.Key(10)]
        public UserAchievementState State { get; init; }

        /// <summary>
        /// Completions the user earned over the achievement's lifetime, including live
        /// completions of the current instance not yet recorded.
        /// </summary>
        [MessagePack.Key(11)]
        public int TotalCompletions { get; init; }

        /// <summary>
        /// Start of the current range instance (UTC).
        /// </summary>
        [MessagePack.Key(12)]
        public DateTime InstanceStart { get; init; }

        /// <summary>
        /// End of the current range instance (UTC, exclusive) — when earning resets.
        /// </summary>
        [MessagePack.Key(13)]
        public DateTime InstanceEnd { get; init; }

        /// <summary>
        /// Completions earned within the current range instance, including live completions
        /// not yet recorded when progress was collected; recorded completions only otherwise.
        /// </summary>
        [MessagePack.Key(14)]
        public int InstanceCompletions { get; init; }

        /// <summary>
        /// The user's raw signal value within the current range instance, in the signal's
        /// native unit. Null when not collected, when the instance was already at its cap
        /// before measurement, or when the signal is unmeasurable.
        /// </summary>
        [MessagePack.Key(15)]
        public decimal? CurrentValue { get; init; }

        /// <summary>
        /// Fractional progress (0–100) toward the next completion of the current instance.
        /// Null when not collected, at the instance cap, or unmeasurable — never zero to mean
        /// "not collected".
        /// </summary>
        [MessagePack.Key(16)]
        public decimal? Progress { get; init; }

        /// <summary>
        /// The badge image's MIME type — the badge dispatches by format (an svg upload is the
        /// template itself, a raster upload is the emblem inside the built-in template). Null
        /// when there is no image or the stored type is unknown (untyped legacy upload).
        /// </summary>
        [MessagePack.Key(17)]
        public string? ImageMimeType { get; init; }
    }
}
