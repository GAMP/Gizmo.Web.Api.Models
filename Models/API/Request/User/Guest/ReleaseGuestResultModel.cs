namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Release guest result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ReleaseGuestResultModel : IWebApiModel
    {
        /// <summary>
        /// Result.
        /// </summary>
        [MessagePack.Key(0)]
        public required ReleaseGuestResult Result { get; init; }
    }
}
