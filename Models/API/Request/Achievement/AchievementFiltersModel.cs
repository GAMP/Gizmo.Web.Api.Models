using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Achievement activity filters — restricts which activity counts towards the achievement.
    /// </summary>
    /// <remarks>
    /// Mirrors the signal query filter shape: values within one kind combine as ANY-of,
    /// different kinds must all hold. A null or empty collection means the filter is absent.
    /// Present kinds must be supported by the achievement's signal
    /// (<see cref="AchievementSignalModel.SupportedFilters"/>).
    /// </remarks>
    [MessagePack.MessagePackObject]
    public sealed class AchievementFiltersModel : IWebApiModel
    {
        /// <summary>
        /// Host filter values.
        /// </summary>
        [MessagePack.Key(0)]
        public IReadOnlyList<int>? HostIds { get; init; }

        /// <summary>
        /// Host group filter values.
        /// </summary>
        [MessagePack.Key(1)]
        public IReadOnlyList<int>? HostGroupIds { get; init; }

        /// <summary>
        /// Branch filter values.
        /// </summary>
        [MessagePack.Key(2)]
        public IReadOnlyList<int>? BranchIds { get; init; }

        /// <summary>
        /// Application filter values.
        /// </summary>
        [MessagePack.Key(3)]
        public IReadOnlyList<int>? AppIds { get; init; }

        /// <summary>
        /// Application executable filter values.
        /// </summary>
        [MessagePack.Key(4)]
        public IReadOnlyList<int>? AppExeIds { get; init; }

        /// <summary>
        /// Application group filter values.
        /// </summary>
        [MessagePack.Key(5)]
        public IReadOnlyList<int>? AppGroupIds { get; init; }

        /// <summary>
        /// Application category filter values.
        /// </summary>
        [MessagePack.Key(6)]
        public IReadOnlyList<int>? AppCategoryIds { get; init; }

        /// <summary>
        /// Product filter values.
        /// </summary>
        [MessagePack.Key(7)]
        public IReadOnlyList<int>? ProductIds { get; init; }

        /// <summary>
        /// Product group filter values.
        /// </summary>
        [MessagePack.Key(8)]
        public IReadOnlyList<int>? ProductGroupIds { get; init; }

        /// <summary>
        /// Bill profile filter values.
        /// </summary>
        [MessagePack.Key(9)]
        public IReadOnlyList<int>? BillProfileIds { get; init; }

        /// <summary>
        /// Payment method filter values.
        /// </summary>
        [MessagePack.Key(10)]
        public IReadOnlyList<int>? PaymentMethodIds { get; init; }

        /// <summary>
        /// Day window filter values — day-anchored, optionally time-narrowed windows.
        /// </summary>
        [MessagePack.Key(11)]
        public IReadOnlyList<AchievementDayWindowModel>? DayWindows { get; init; }
    }
}
