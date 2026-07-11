using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A day-anchored activity window of an achievement filter.
    /// </summary>
    /// <remarks>
    /// A null time window means the entire day; both bounds are required together. A window
    /// whose start is later than its end extends past midnight into the next calendar day and
    /// is still attributed to <see cref="Day"/> — "(Friday, 22:00–06:00)" is Friday night
    /// including Saturday's early hours. Multiple entries may share a day to express multiple
    /// windows within it.
    /// </remarks>
    [MessagePack.MessagePackObject]
    public sealed class AchievementDayWindowModel : IWebApiModel
    {
        /// <summary>
        /// Day of week the window is anchored to.
        /// </summary>
        [MessagePack.Key(0)]
        public DayOfWeek Day { get; init; }

        /// <summary>
        /// Optional window start time of day.
        /// </summary>
        [MessagePack.Key(1)]
        public TimeSpan? DayTimeFrom { get; init; }

        /// <summary>
        /// Optional window end time of day.
        /// </summary>
        [MessagePack.Key(2)]
        public TimeSpan? DayTimeTo { get; init; }
    }
}
