namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Achievement ladder scoring modes.
    /// </summary>
    public enum AchievementLadderMode
    {
        /// <summary>
        /// Achievements award points per completion; levels are reached by point thresholds.
        /// </summary>
        Points = 0,

        /// <summary>
        /// Levels list required achievements; the highest satisfied level wins.
        /// </summary>
        Requirements = 1,
    }
}
