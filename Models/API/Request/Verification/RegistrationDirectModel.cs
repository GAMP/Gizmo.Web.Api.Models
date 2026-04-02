using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Direct registration model (no verification required).
    /// </summary>
    [MessagePackObject]
    public sealed class RegistrationDirectModel
    {
        /// <summary>
        /// User profile data.
        /// </summary>
        [Key(0)]
        public UserProfileModelCreate Profile { get; set; } = null!;

        /// <summary>
        /// Password for the new account.
        /// </summary>
        [Key(1)]
        public string? Password { get; set; }
    }
}
