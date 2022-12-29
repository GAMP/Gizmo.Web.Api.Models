using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time product disallowed host group.
    /// </summary>
    [MessagePackObject]
    public sealed class TimeProductDisallowedHostGroupModelCreate : ITimeProductDisallowedHostGroupApiModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the host group.
        /// </summary>
        [Key(0)]
        public int HostGroupId { get; set; }

        /// <summary>
        /// Whether this host group is disallowed for this time product.
        /// </summary>
        [Key(1)]
        public bool IsDisallowed { get; set; }

        #endregion
    }
}