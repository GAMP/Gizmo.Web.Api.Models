using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Period Utilization Chart Record.
    /// </summary>
    [MessagePackObject]
    public class PeriodUtilizationChartRecordModel
    {
        /// <summary>
        /// The name of the chart record.
        /// </summary>
        [Key(0)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The value of the chart record.
        /// </summary>
        [Key(1)]
        public decimal Value { get; set; }

        /// <summary>
        /// Period total seconds multiplied by the number of available hosts.
        /// </summary>
        [Key(2)]
        public int TotalSeconds { get; set; }

        /// <summary>
        /// Period used seconds based on user sessions.
        /// </summary>
        [Key(3)]
        public int UsedSeconds { get; set; }
    }
}
