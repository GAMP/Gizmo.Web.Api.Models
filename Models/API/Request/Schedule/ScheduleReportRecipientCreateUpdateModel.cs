using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Schedule report recipient create/update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ScheduleReportRecipientCreateUpdateModel : IWebApiModel
    {
        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserId { get; init; }

        /// <summary>
        /// Channels.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<Guid> Channels { get; init; } = Enumerable.Empty<Guid>();

        /// <summary>
        /// Is disabled.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsDisabled { get; init; }
    }
}
