namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Chart Record.
    /// </summary>
    [MessagePack.MessagePackObject]
    public class ChartRecordModel
    {
        /// <summary>
        /// The name of the chart record.
        /// </summary>
        [MessagePack.Key(0)]
        public string? Name { get; set; }

        /// <summary>
        /// The value of the chart record.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal Value { get; set; }
    }
}
