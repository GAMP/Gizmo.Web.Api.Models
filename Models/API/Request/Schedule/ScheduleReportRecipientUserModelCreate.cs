using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Schedule report recipient create model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ScheduleReportRecipientUserModelCreate : IWebApiModel
    {
        [MessagePack.Key(0)]
        public int UserId { get; init; }

        [MessagePack.Key(1)]
        public IEnumerable<Guid> Channels { get; init; }
    }
}
