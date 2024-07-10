using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User logout result.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserLogoutResultModel
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
