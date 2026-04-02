using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Registration completion model.
    /// </summary>
    [MessagePackObject]
    public sealed class RegistrationCompleteModel
    {
        /// <summary>
        /// Token value from the registration start step.
        /// </summary>
        [Key(0)]
        public string Token { get; set; } = null!;

        /// <summary>
        /// Confirmation code. Null when the token was confirmed via redirect callback.
        /// </summary>
        [Key(1)]
        public string? ConfirmationCode { get; set; }

        /// <summary>
        /// User profile data.
        /// </summary>
        [Key(2)]
        public UserProfileModelCreate Profile { get; set; } = null!;

        /// <summary>
        /// Password for the new account.
        /// </summary>
        [Key(3)]
        public string? Password { get; set; }
    }
}
