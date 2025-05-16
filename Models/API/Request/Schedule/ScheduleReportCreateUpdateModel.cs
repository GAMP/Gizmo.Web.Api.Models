using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Schedule report create model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class ScheduleReportCreateUpdateModel : IScheduleModel
    {
        ///<inheritdoc/>
        [MessagePack.Key(0)]
        public string Name { get; init; } = null!;

        ///<inheritdoc/>
        [MessagePack.Key(1)]
        public string? Description { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(2)]
        public ScheduleType Type { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(3)]
        public TimeSpan StartTime { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(4)]
        public bool IsDisabled { get; init; }

        /// <summary>
        /// Entries.
        /// </summary>
        [MessagePack.Key(5)]
        public IEnumerable<ScheduleReportEntryCreateUpdateModel> Entries { get; init; } = Enumerable.Empty<ScheduleReportEntryCreateUpdateModel>();

        /// <summary>
        /// Recipients.
        /// </summary>
        [MessagePack.Key(6)]
        public IEnumerable<ScheduleReportRecipientCreateUpdateModel> Recipients { get; init; } = Enumerable.Empty<ScheduleReportRecipientCreateUpdateModel>();
    }
}
