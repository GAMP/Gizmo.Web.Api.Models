using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.User.Group.DisallowedHostGroup
{
    /// <summary>
    /// User group disallowed host group.
    /// </summary>
    [MessagePackObject]
    public sealed class UserGroupDisallowedHostGroup : IUserGroupDisallowedHostGroupApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the user group.
        /// </summary>
        [MessagePack.Key(1)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// The Id of the host group.
        /// </summary>
        [MessagePack.Key(2)]
        public int HostGroupId { get; set; }

        /// <summary>
        /// Whether this host group is disallowed for this user group.
        /// </summary>
        [MessagePack.Key(3)]
        public bool IsDisallowed { get; set; }

        #endregion
    }
}