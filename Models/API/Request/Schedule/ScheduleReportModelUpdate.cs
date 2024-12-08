using System;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Schedule report model update.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class ScheduleReportModelUpdate : IScheduleModel, IModelIntIdentifier
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
    }
}
