using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Operator-facing phone verification start request.
    /// </summary>
    [MessagePackObject]
    public sealed class OperatorPhoneVerificationStartModel : VerificationStartModelBase
    {
        /// <summary>
        /// Target user identifier.
        /// </summary>
        [Key(2)]
        public int UserId { get; set; }

        /// <summary>
        /// Optional phone number to verify.
        /// When set, initiates verification of this specific phone number (new phone).
        /// When null, re-verifies the user's existing phone.
        /// </summary>
        [Key(3)]
        public string? PhoneNumber { get; set; }
    }
}
