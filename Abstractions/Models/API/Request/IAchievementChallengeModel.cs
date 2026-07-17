using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Achievement challenge model — the operator-editable surface.
    /// </summary>
    public interface IAchievementChallengeModel : IWebApiModel
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
        /// Optional UTC start of the challenge window.
        /// Null means the window opens at challenge creation.
        /// </summary>
        DateTime? StartTime { get; init; }

        /// <summary>
        /// Optional UTC end of the challenge window. Null means the challenge is evergreen.
        /// </summary>
        DateTime? EndTime { get; init; }

        /// <summary>
        /// Maximum completions per user within the window. Null means unlimited —
        /// a recurring reward earned every time the requirements are met again.
        /// </summary>
        int? MaxCompletions { get; init; }

        /// <summary>
        /// Total completion pool across all users — "first N finishers".
        /// Null means uncapped.
        /// </summary>
        int? GlobalMaxCompletions { get; init; }

        /// <summary>
        /// Option flags.
        /// </summary>
        AchievementChallengeOptionType Options { get; init; }

        /// <summary>
        /// Indicates if the challenge is disabled.
        /// </summary>
        bool IsDisabled { get; init; }

        /// <summary>
        /// Optional badge image id.
        /// </summary>
        int? ImageId { get; init; }

        /// <summary>
        /// Achievements required to complete the challenge. At least one is required.
        /// </summary>
        IReadOnlyList<AchievementChallengeRequirementModel> Requirements { get; init; }

        /// <summary>
        /// Points rewards granted per completion. Null means none.
        /// </summary>
        IReadOnlyList<AchievementChallengePointsRewardModel>? PointsRewards { get; init; }

        /// <summary>
        /// Product rewards granted per completion. Null means none.
        /// </summary>
        IReadOnlyList<AchievementChallengeProductRewardModel>? ProductRewards { get; init; }

        /// <summary>
        /// Time rewards granted per completion. Null means none.
        /// </summary>
        IReadOnlyList<AchievementChallengeTimeRewardModel>? TimeRewards { get; init; }
    }
}
