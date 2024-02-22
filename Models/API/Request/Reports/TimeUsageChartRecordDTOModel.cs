namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Chart record for the usage of time products.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class TimeUsageChartRecordDTOModel
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

        /// <summary>
        /// Number of products that was used before void. 
        /// </summary>
        [MessagePack.Key(2)]
        public int Voids { get; set; }
    }
}
