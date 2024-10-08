using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User user group.
    /// </summary>
    [MessagePackObject]
    public sealed class UserUserGroupModelUpdate
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the users group id this user belongs to.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserGroupId { get; set; }

        #endregion
    }
}
