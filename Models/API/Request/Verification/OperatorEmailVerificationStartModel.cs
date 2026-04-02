using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Operator-facing email verification start request.
    /// </summary>
    [MessagePackObject]
    public sealed class OperatorEmailVerificationStartModel : VerificationStartModelBase
    {
        /// <summary>
        /// Target user identifier.
        /// </summary>
        [Key(2)]
        public int UserId { get; set; }

        /// <summary>
        /// Optional email address to verify.
        /// When set, initiates verification of this specific email (new email).
        /// When null, re-verifies the user's existing email.
        /// </summary>
        [Key(3)]
        public string? Email { get; set; }
    }
}
