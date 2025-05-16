using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Schedule model.
    /// </summary>
    public interface IScheduleModel : IWebApiModel
    {
        /// <summary>
        /// Schedule name.
        /// </summary>
        public string Name { get; init; }

        /// <summary>
        /// Schedule description.
        /// </summary>
        public string? Description { get; init; }

        /// <summary>
        /// Schedule type.
        /// </summary>
        public ScheduleType Type { get; init; }

        /// <summary>
        /// Schedule start time.
        /// </summary>
        public TimeSpan StartTime { get; init; }

        /// <summary>
        /// IsDisabled.
        /// </summary>
        public bool IsDisabled { get; init; }
    }
}
