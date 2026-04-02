using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User-facing email verification start request.
    /// </summary>
    [MessagePackObject]
    public sealed class UserEmailVerificationStartModel : VerificationStartModelBase
    {
        /// <summary>
        /// Optional email address to verify.
        /// When set, initiates verification of this specific email (new email).
        /// When null, re-verifies the user's existing email.
        /// </summary>
        [Key(2)]
        public string? Email { get; set; }
    }
}
