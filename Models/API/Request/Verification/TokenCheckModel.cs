using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Token confirmation status check model.
    /// </summary>
    [MessagePackObject]
    public sealed class TokenCheckModel : IWebApiModel
    {
        /// <summary>
        /// Token value.
        /// </summary>
        [Key(0)]
        public string Token { get; set; } = null!;
    }
}
