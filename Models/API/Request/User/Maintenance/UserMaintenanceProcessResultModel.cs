using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Result returned when a user-maintenance background process is enqueued.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class UserMaintenanceProcessResultModel : IWebApiModel
    {
        /// <summary>
        /// Background process identifier.
        /// </summary>
        [MessagePack.Key(0)]
        public required Guid ProcessId { get; init; }
    }
}
