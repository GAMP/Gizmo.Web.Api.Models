using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User group delete result.
    /// </summary>
    [MessagePackObject]
    public sealed class UserGroupDeleteResultModel : IWebApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// User group delete result.
        /// </summary>
        [MessagePack.Key(0)]
        public UserGroupDeleteResult UserGroupDeleteResult { get; init; }

        #endregion
    }
}
