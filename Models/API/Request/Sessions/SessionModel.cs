using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Session.
    /// </summary>
    [MessagePackObject]
    public sealed class SessionModel : IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        [MessagePack.Key(1)]
        public int UserId { get; set; }

        [MessagePack.Key(2)]
        public DateTime? StartTime { get; set; }

        [MessagePack.Key(3)]
        public DateTime? EndTime { get; set; }

        [MessagePack.Key(4)]
        public double Span { get; set; }

        [MessagePack.Key(5)]
        public double BilledSpan { get; set; }

        [MessagePack.Key(6)]
        public decimal Charge { get; set; }

        [MessagePack.Key(7)]
        public double PrepaidFixed { get; set; }

        [MessagePack.Key(8)]
        public double PrepaidProdutTime { get; set; }

        [MessagePack.Key(9)]
        public string? EndpointName { get; set; }

        [MessagePack.Key(10)]
        public int? UsageSessionId { get; set; }

        [MessagePack.Key(11)]
        public bool IsFirstUsageSession { get; set; }

        #endregion
    }
}
