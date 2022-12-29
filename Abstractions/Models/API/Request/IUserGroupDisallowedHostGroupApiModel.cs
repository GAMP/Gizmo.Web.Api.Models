namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// User group disallowed host group.
    /// </summary>
    public interface IUserGroupDisallowedHostGroupApiModel
    {
        /// <summary>
        /// The Id of the host group.
        /// </summary>
        int HostGroupId { get; set; }

        /// <summary>
        /// Whether this host group is disallowed for this user group.
        /// </summary>
        bool IsDisallowed { get; set; }
    }
}