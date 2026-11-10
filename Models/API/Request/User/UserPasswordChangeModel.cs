using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Current user password change model.
    /// </summary>
    /// <remarks>
    /// The fields are validated by the server (not by model validation), so an empty field gives the documented
    /// property error: CurrentPassword (WRONG_PASSWORD) or NewPassword.
    /// </remarks>
    [MessagePackObject]
    public sealed class UserPasswordChangeModel
    {
        /// <summary>
        /// The current password of the user.
        /// </summary>
        [MessagePack.Key(0)]
        public string? CurrentPassword { get; set; }

        /// <summary>
        /// The new password of the user.
        /// </summary>
        [MessagePack.Key(1)]
        public string? NewPassword { get; set; }
    }
}
