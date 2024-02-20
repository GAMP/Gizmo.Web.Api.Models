using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Group Sessions Estimation.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class GroupSessionsEstimationModel
    {
        /// <summary>
        /// Group name.
        /// </summary>
        [MessagePack.Key(0)]
        public string? Name { get; set; }

        /// <summary>
        /// The time the session was running as text.
        /// </summary>
        [MessagePack.Key(1)]
        public string? Duration { get; set; }

        /// <summary>
        /// Duration of the user session in minutes.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal TotalMinutes { get; set; }

        /// <summary>
        /// Hours used percentage in comparison with other groups within the same period.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal HoursPercentage { get; set; }

        /// <summary>
        /// Packet minutes.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Packet cost.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal Value { get; set; }

        /// <summary>
        /// Estimated revenue percentage in comparison with other groups within the same period.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal EstimatedRevenuePercentage { get; set; }

        [MessagePack.Key(7)]
        public List<GroupSessionsEstimationModel>? SubGroupSessionsEstimations { get; set; }
    }
}
