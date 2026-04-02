using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User-facing password recovery start request.
    /// </summary>
    [MessagePackObject]
    public sealed class UserPasswordRecoveryStartModel : VerificationStartModelBase
    {
        /// <summary>
        /// Value to match the user by (username, phone number, or email).
        /// </summary>
        [Key(2)]
        public string MatchValue { get; set; } = null!;
    }
}
