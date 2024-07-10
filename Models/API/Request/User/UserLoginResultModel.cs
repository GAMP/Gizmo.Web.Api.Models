using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User login result.
    /// </summary>
    [MessagePackObject]
    public sealed class UserLoginResultModel : IWebApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// Login result.
        /// </summary>
        [MessagePack.Key(0)]
        public LoginResult LoginResult { get; init; }

        #endregion
    }
}
