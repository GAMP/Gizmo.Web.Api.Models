using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User login result.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserLoginResultModel
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
