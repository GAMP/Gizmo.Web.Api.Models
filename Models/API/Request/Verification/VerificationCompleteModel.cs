using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Verification completion request.
    /// </summary>
    [MessagePackObject]
    public sealed class VerificationCompleteModel
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
    }
}
