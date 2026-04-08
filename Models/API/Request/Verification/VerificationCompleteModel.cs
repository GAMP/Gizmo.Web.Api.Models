using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Verification completion model.
    /// Token must be confirmed (via redirect callback or TokenConfirm) before calling complete.
    /// </summary>
    [MessagePackObject]
    public sealed class VerificationCompleteModel : IWebApiModel
    {
        /// <summary>
        /// Token value.
        /// </summary>
        [Key(0)]
        public string Token { get; set; } = null!;
    }
}
