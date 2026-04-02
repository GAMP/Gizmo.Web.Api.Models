using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Result of starting a verification operation.
    /// </summary>
    [MessagePackObject]
    public sealed class VerificationStartResultModel
    {
        /// <summary>
        /// Result code.
        /// </summary>
        [Key(0)]
        public VerificationStartResultCode Result { get; set; }

        /// <summary>
        /// Token value for completing the verification.
        /// </summary>
        [Key(1)]
        public string? Token { get; set; }

        /// <summary>
        /// Redirect URL for the user to visit.
        /// Present when delivery method is <see cref="VerificationDeliveryMethod.Redirect"/>.
        /// </summary>
        [Key(2)]
        public string? RedirectUrl { get; set; }

        /// <summary>
        /// Confirmation code length.
        /// Present when delivery method is <see cref="VerificationDeliveryMethod.CodeDispatch"/>.
        /// </summary>
        [Key(3)]
        public int CodeLength { get; set; }

        /// <summary>
        /// Number of seconds before the redirect URL or token expires.
        /// </summary>
        [Key(4)]
        public int ExpiresInSeconds { get; set; }
    }
}
