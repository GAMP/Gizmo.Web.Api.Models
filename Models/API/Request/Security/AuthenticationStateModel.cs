using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Authentication state model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class AuthenticationStateModel : IWebApiModel
    {
        /// <summary>
        /// Gets or sets the authentication state.
        /// </summary>
        [MessagePack.Key(0)]
        public AuthenticationState State { get; init; }

        /// <summary>
        /// Gets or sets the claims.
        /// </summary>
        [MessagePack.Key(1)]
        public ClaimModel[] Claims { get; init; } = Array.Empty<ClaimModel>();
    }
}
