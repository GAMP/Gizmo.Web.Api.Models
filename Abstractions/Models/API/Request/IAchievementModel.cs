using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Achievement model — the operator-editable surface.
    /// </summary>
    /// <remarks>
    /// The signal and calendar range are deliberately absent: they define the deed's
    /// identity and are immutable after creation (the update model cannot express a
    /// change). To measure something else, create a new achievement and disable the
    /// old one. They are declared on the create and read models directly.
    /// </remarks>
    public interface IAchievementModel : IWebApiModel
    {
        /// <summary>
        /// Name.
        /// </summary>
        string Name { get; init; }

        /// <summary>
        /// Optional customer-facing description.
        /// </summary>
        string? Description { get; init; }

        /// <summary>
        /// Target signal value to accumulate within one range, in the signal's native unit.
        /// </summary>
        decimal Value { get; init; }

        /// <summary>
        /// Maximum completions within one range instance.
        /// </summary>
        int MaxCompletionsPerRange { get; init; }

        /// <summary>
        /// Option flags.
        /// </summary>
        AchievementOptionType Options { get; init; }

        /// <summary>
        /// Indicates if the achievement is disabled.
        /// </summary>
        bool IsDisabled { get; init; }

        /// <summary>
        /// Activity filters. Null means no filters.
        /// </summary>
        AchievementFiltersModel? Filters { get; init; }

        /// <summary>
        /// Custom signal parameter values. Null means no parameters.
        /// </summary>
        IReadOnlyList<AchievementParameterModel>? Parameters { get; init; }
    }
}
