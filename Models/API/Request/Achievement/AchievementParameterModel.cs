namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A custom signal parameter value assigned on an achievement.
    /// </summary>
    /// <remarks>
    /// Keys and values are validated against the signal's declared parameter metadata
    /// (<see cref="AchievementSignalModel.Parameters"/>).
    /// </remarks>
    [MessagePack.MessagePackObject]
    public sealed class AchievementParameterModel : IWebApiModel
    {
        /// <summary>
        /// Parameter key (e.g. <c>game.wins</c>).
        /// </summary>
        [MessagePack.Key(0)]
        public string Key { get; init; } = string.Empty;

        /// <summary>
        /// Parameter value.
        /// </summary>
        [MessagePack.Key(1)]
        public string? Value { get; init; }
    }
}
