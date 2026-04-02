using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User-facing phone verification start request.
    /// </summary>
    [MessagePackObject]
    public sealed class UserPhoneVerificationStartModel : VerificationStartModelBase
    {
        /// <summary>
        /// Optional phone number to verify.
        /// When set, initiates verification of this specific phone number (new phone).
        /// When null, re-verifies the user's existing phone.
        /// </summary>
        [Key(2)]
        public string? PhoneNumber { get; set; }
    }
}
