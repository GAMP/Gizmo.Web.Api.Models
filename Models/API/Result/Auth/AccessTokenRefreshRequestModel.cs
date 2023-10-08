using Gizmo.Web.Api.Models.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Access token refresh model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AccessTokenRefreshRequestModel : IUriParametersQuery
    {
        /// <summary>
        /// Token.
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
