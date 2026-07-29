using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device activation session creation result.
    /// </summary>
    [MessagePackObject]
    public sealed class DeviceAuthSessionResultModel : IWebApiModel
    {
        /// <summary>
        /// One time session nonce. Secret, single use; identifies this activation attempt.
        /// </summary>
        [Key(0)]
        public string Nonce { get; init; } = string.Empty;

        /// <summary>
        /// Short human readable code shown as a no-camera fallback.
        /// </summary>
        [Key(1)]
        public string HumanCode { get; init; } = string.Empty;

        /// <summary>
        /// Session lifetime in seconds.
        /// </summary>
        [Key(2)]
        public int ExpiresInSeconds { get; init; }

        /// <summary>
        /// Server relative activation path including the nonce, e.g. "/activate?code=...".
        /// Fallback for composing the url from the device's configured server address.
        /// </summary>
        [Key(3)]
        public string ActivatePath { get; init; } = string.Empty;

        /// <summary>
        /// Absolute activation url from the server's perspective, built from the advertised
        /// host (network options) so it stays reachable from other devices such as phones.
        /// Preferred over <see cref="ActivatePath"/> when present.
        /// </summary>
        [Key(4)]
        public string ActivateUrl { get; init; } = string.Empty;
    }
}
