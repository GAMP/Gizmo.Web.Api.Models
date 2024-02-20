namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Overview Report Operator Statistics.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class OverviewReportOperatorStatisticsDTOModel
    {
        /// <summary>
        /// Operator Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int OperatorId { get; set; }

        /// <summary>
        /// Operator name.
        /// </summary>
        [MessagePack.Key(1)]
        public string? OperatorName { get; set; }

        /// <summary>
        /// Total minutes the operator worked.
        /// </summary>
        [MessagePack.Key(2)]
        public int MinutesWorked { get; set; }

        /// <summary>
        /// Total hours the operator worked as text.
        /// </summary>
        [MessagePack.Key(3)]
        public string HoursWorked { get; set; } = string.Empty;

        /// <summary>
        /// Total minutes the operator sold.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal MinutesSold { get; set; }

        /// <summary>
        /// Total hours the operator sold as text.
        /// </summary>
        [MessagePack.Key(5)]
        public string HoursSold { get; set; } = string.Empty;

        /// <summary>
        /// Number of products the operator sold.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal ProductsSold { get; set; }

        /// <summary>
        /// Number of time offers the operator sold.
        /// </summary>
        [MessagePack.Key(7)]
        public decimal TimeOffersSold { get; set; }

        /// <summary>
        /// Number of bundles the operator sold.
        /// </summary>
        [MessagePack.Key(8)]
        public decimal BundlesSold { get; set; }

        /// <summary>
        /// Number of voids the operator performed.
        /// </summary>
        [MessagePack.Key(9)]
        public int Voids { get; set; }

        /// <summary>
        /// Total amount of register transactions performed by the operator.
        /// </summary>
        [MessagePack.Key(10)]
        public decimal RegisterTransactionsTotal { get; set; }

        /// <summary>
        /// Operator revenue.
        /// </summary>
        [MessagePack.Key(11)]
        public decimal Revenue { get; set; }
    }
}
