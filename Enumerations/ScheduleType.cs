using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Schedule type.
    /// </summary>
    public enum ScheduleType
    {
        /// <summary>
        /// Daily schedule.
        /// </summary>
        [Name("Daily", "SCHEDULE_TYPE_DAILY")]
        Daily = 0,

        /// <summary>
        /// Weekly schedule.
        /// </summary>
        [Name("Weekly", "SCHEDULE_TYPE_WEEKLY")]
        Weekly = 1,

        /// <summary>
        /// Monthly schedule.
        /// </summary>
        [Name("Monthly", "SCHEDULE_TYPE_MONTHLY")]
        Monthly = 2,

        /// <summary>
        /// Yearly schedule.
        /// </summary>
        [Name("Yearly", "SCHEDULE_TYPE_YEARLY")]
        Yearly = 3,

        /// <summary>
        /// One time schedule.
        /// </summary>
        [Name("One Time", "SCHEDULE_TYPE_ONE_TIME")]
        OneTime = 4
    }
}
