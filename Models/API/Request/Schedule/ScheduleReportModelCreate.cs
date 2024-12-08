using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Schedule report create model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class ScheduleReportModelCreate : IScheduleModel
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
    }
}
