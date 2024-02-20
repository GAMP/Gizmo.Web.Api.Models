using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Enumerations
{
    /// <summary>
    /// Report preset range.
    /// </summary>
    public enum ReportPresetRange
    {
        /// <summary>
        /// Day.
        /// </summary>
        [Name("Day","REPORT_PRESET_RANGE_DAY_NAME")]
        Day = 0,

        /// <summary>
        /// Week.
        /// </summary>
        [Name("Week","REPORT_PRESET_RANGE_WEEK_NAME")]
        Week = 1,

        /// <summary>
        /// Month.
        /// </summary>
        [Name("Month", "REPORT_PRESET_RANGE_MONTH_NAME")]
        Month = 2,

        /// <summary>
        /// Year.
        /// </summary>
        [Name("Year", "REPORT_PRESET_RANGE_YEAR_NAME")]
        Year = 3,
    }
}
