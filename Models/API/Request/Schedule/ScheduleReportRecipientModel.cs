using System.Collections.Generic;
using System;
using Gizmo.Web.Api.Models.Abstractions;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Schedule report recipient model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ScheduleReportRecipientModel : RecipientModel , IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Schedule report id.
        /// </summary>
        [MessagePack.Key(1)]
        public int SchedulerReportId { get; init; }

        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(2)]
        public int UserId { get; set; }

        /// <summary>
        /// Channels.
        /// </summary>
        [MessagePack.Key(3)]
        public IEnumerable<Guid> Channels { get; set; } = Enumerable.Empty<Guid>();

        /// <summary>
        /// Is disabled.
        /// </summary>
        [MessagePack.Key(4)]
        public bool IsDisabled { get; init; }
    }
}
