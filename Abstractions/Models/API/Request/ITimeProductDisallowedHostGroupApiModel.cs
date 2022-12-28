namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Time product disallowed host group.
    /// </summary>
    public interface ITimeProductDisallowedHostGroupApiModel
    {
        /// <summary>
        /// The Id of the host group.
        /// </summary>
        int HostGroupId { get; set; }

        /// <summary>
        /// Whether this host group is disallowed for this time product.
        /// </summary>
        bool IsDisallowed { get; set; }
    }
}