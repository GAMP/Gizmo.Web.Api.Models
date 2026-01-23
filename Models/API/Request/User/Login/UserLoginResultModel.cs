namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User login result.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class UserLoginResultModel : IWebApiModel
    {
        /// <summary>
        /// Login result.
        /// </summary>
        [MessagePack.Key(0)]
        public LoginResult LoginResult { get; init; }
    }
}
