using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Password recovery completion request.
    /// </summary>
    [MessagePackObject]
    public sealed class PasswordRecoveryCompleteModel
    {
        /// <summary>
        /// Token value.
        /// </summary>
        [Key(0)]
        public string Token { get; set; } = null!;

        /// <summary>
        /// Confirmation code. Null when the token was confirmed via redirect callback.
        /// </summary>
        [Key(1)]
        public string? ConfirmationCode { get; set; }

        /// <summary>
        /// New password.
        /// </summary>
        [Key(2)]
        public string NewPassword { get; set; } = null!;
    }
}
