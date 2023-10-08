using Gizmo.Web.Api.Models.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User access token refresh request model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserAccessTokenRefreshRequestModel : IUriParametersQuery
    {
        /// <summary>
        /// Access token.
        /// </summary>
        [MessagePack.Key(0)]
        [Required(AllowEmptyStrings = false)]
        public string Token { get; init; } = string.Empty;

        /// <summary>
        /// Refresh token.
        /// </summary>
        [MessagePack.Key(1)]
        [Required(AllowEmptyStrings = false)]
        public string RefreshToken { get; init; } = string.Empty;
    }
}
