namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time zone information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class TimeZoneInfoModel : IWebApiModel
    {
        /// <summary>
        /// Gets or sets the time zone id.
        /// </summary>
        [MessagePack.Key(0)]
        public string Id { get; init; } = null!;

        /// <summary>
        /// Gets or sets the time zone display name.
        /// </summary>
        [MessagePack.Key(1)]
        public string DisplayName { get; init; } = null!;
    }
}
