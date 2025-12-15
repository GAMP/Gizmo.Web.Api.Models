namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order intent user model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderIntentUserModel : IWebApiModel
    {
        /// <summary>
        /// User identifier.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserId { get; init; }

        /// <summary>
        /// Points award.
        /// </summary>
        [MessagePack.Key(1)]
        public int Award { get; init; }
    }
}
