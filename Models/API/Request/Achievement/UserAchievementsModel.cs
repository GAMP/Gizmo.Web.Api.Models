using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A user's achievements view — the visible achievements with the user's standing on each.
    /// </summary>
    /// <remarks>
    /// Visible achievements are the active non-hidden ones plus any the user has completions
    /// on: hidden achievements appear only once earned, and paused or archived ones stay
    /// visible once earned. Unknown users fail the standard entity-not-found way.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class UserAchievementsModel : IWebApiModel
    {
        /// <summary>
        /// The visible achievements with the user's standing, ordered by name.
        /// </summary>
        [MessagePack.Key(0)]
        public IReadOnlyList<UserAchievementModel> Achievements { get; init; } = System.Array.Empty<UserAchievementModel>();
    }
}
