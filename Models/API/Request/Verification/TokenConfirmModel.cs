using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Token confirmation model.
    /// Validates the confirmation code and marks the token as confirmed.
    /// </summary>
    [MessagePackObject]
    public sealed class TokenConfirmModel : IWebApiModel
    {
        /// <summary>
        /// Token value.
        /// </summary>
        [Key(0)]
        public string Token { get; set; } = null!;

        /// <summary>
        /// Confirmation code.
        /// </summary>
        [Key(1)]
        public string ConfirmationCode { get; set; } = null!;
    }
}
