using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Minimal SSE notification emitted when a host's status changes.
    /// Clients should call GET hosts/{HostId}/status to fetch updated state.
    /// </summary>
    [MessagePackObject]
    public sealed class HostStatusChangedNotification : IWebApiModel
    {
        public HostStatusChangedNotification(int hostId)
        {
            HostId = hostId;
        }

        /// <summary>
        /// The id of the host whose status changed.
        /// </summary>
        [Key(0)]
        public int HostId { get; init; }
    }
}
