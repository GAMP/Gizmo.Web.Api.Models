using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Registration completion model.
    /// Token must be confirmed (via redirect callback or TokenConfirm) before calling complete.
    /// </summary>
    [MessagePackObject]
    public sealed class RegistrationCompleteModel : IWebApiModel
    {
        /// <summary>
        /// Token value from the registration start step.
        /// </summary>
        [Key(0)]
        public string Token { get; set; } = null!;

        /// <summary>
        /// User profile data.
        /// </summary>
        [Key(1)]
        public UserProfileModelCreate Profile { get; set; } = null!;

        /// <summary>
        /// Password for the new account.
        /// </summary>
        [Key(2)]
        public string? Password { get; set; }
    }
}
