namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User logout result.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class UserLogoutResultModel : IWebApiModel
    {
        /// <summary>
        /// Logout result.
        /// </summary>
        [MessagePack.Key(0)]
        public LogoutResult LogoutResult { get; init; }
    }
}
