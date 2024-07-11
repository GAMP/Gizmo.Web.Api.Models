using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User logout result.
    /// </summary>
    [MessagePackObject]
    public sealed class UserLogoutResultModel : IWebApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// Logout result.
        /// </summary>
        [MessagePack.Key(0)]
        public LogoutResult LogoutResult { get; init; }

        #endregion
    }
}
