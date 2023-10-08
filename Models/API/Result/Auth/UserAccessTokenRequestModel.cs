namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User access token request model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserAccessTokenRequestModel
    {
        /// <summary>
        /// Username.
        /// </summary>
        [MessagePack.Key(0)]
        public string Token { get; init; } = string.Empty;

        /// <summary>
        /// Password.
        /// </summary>
        [MessagePack.Key(1)]
        public string RefreshToken { get; init; } = string.Empty;
    }
}
