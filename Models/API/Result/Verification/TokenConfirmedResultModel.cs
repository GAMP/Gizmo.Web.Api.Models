using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Token confirmation state result.
    /// </summary>
    [MessagePackObject]
    public sealed class TokenConfirmedResultModel
    {
        /// <summary>
        /// Indicates whether token has been confirmed.
        /// </summary>
        [Key(0)]
        public bool IsConfirmed { get; set; }

        /// <summary>
        /// Confirmed phone number.
        /// </summary>
        [Key(1)]
        public string? Phone { get; set; }

        /// <summary>
        /// Indicates that a user with the confirmed phone number already exists.
        /// </summary>
        [Key(2)]
        public bool UserAlreadyExists { get; set; }
    }
}
