using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A level of the achievement ladder.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class AchievementLadderLevelModel : IWebApiModel
    {
        /// <summary>
        /// User group customers at this level belong to.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserGroupId { get; init; }

        /// <summary>
        /// Points score required to reach this level. Points mode only; must climb
        /// strictly level to level.
        /// </summary>
        [MessagePack.Key(1)]
        public int Threshold { get; init; }

        /// <summary>
        /// Optional customer-facing level description.
        /// </summary>
        [StringLength(65535)]
        [MessagePack.Key(2)]
        public string? Description { get; init; }

        /// <summary>
        /// Optional badge image id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? ImageId { get; init; }

        /// <summary>
        /// Achievements required to reach this level. Requirements mode only; the entry
        /// (lowest) level requires none.
        /// </summary>
        [MessagePack.Key(4)]
        public IReadOnlyList<AchievementLadderRequirementModel>? Requirements { get; init; }
    }
}
