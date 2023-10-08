namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Access token refresh model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AccessTokenRefreshRequestModel
    {
        /// <summary>
        /// Token.
        /// </summary>
        [MessagePack.Key(0)]
        public string Token { get; init; } = string.Empty;

        /// <summary>
        /// Refresh token.
        /// </summary>
        [MessagePack.Key(1)]
        public string RefreshToken { get; init; } = string.Empty;

        /// <summary>
        /// Branch id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? BranchId
        {
            get; init;
        }
    }
}
