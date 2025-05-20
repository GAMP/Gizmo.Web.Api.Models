using System;
using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Schedule report model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class ScheduleReportModel : ScheduleModel, IScheduleModel , IModelIntIdentifier
    {
        ///<inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(1)]
        public string Name { get; init; } = null!;

        ///<inheritdoc/>
        [MessagePack.Key(2)]
        public string? Description { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(3)]
        public ScheduleType Type { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(4)]
        public TimeSpan StartTime { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(5)]
        public bool IsDisabled { get; init; }

        /// <summary>
        /// Entries.
        /// </summary>
        [MessagePack.Key(6)]
        public IEnumerable<ScheduleReportEntryModel> Entries { get; init; } = Enumerable.Empty<ScheduleReportEntryModel>();

        /// <summary>
        /// Recipients.
        /// </summary>
        [MessagePack.Key(7)]
        public IEnumerable<ScheduleReportRecipientModel> Recipients { get; init; } = Enumerable.Empty<ScheduleReportRecipientModel>();
    }
}
