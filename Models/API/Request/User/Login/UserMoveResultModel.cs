namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User move result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserMoveResultModel : IWebApiModel
    {
        /// <summary>
        /// Login result.
        /// </summary>
        [MessagePack.Key(0)]
        public LoginResult LoginResult { get; set; }
    }
}
