using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Stock count model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class StockCountModel : IWebApiModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Stock id.
        /// </summary>
        [MessagePack.Key(1)]
        public int StockId { get; init; }

        /// <summary>
        /// Count type.
        /// </summary>
        [MessagePack.Key(2)]
        public StockCountType Type { get; init; }

        /// <summary>
        /// Optional note.
        /// </summary>
        [MessagePack.Key(3)]
        public string? Note { get; init; }

        /// <summary>
        /// Entries count.
        /// </summary>
        [MessagePack.Key(4)]
        public int EntriesCount { get; init; }

        /// <summary>
        /// Surplus count.
        /// </summary>
        [MessagePack.Key(5)]
        public int SurplusCount { get; init; }

        /// <summary>
        /// Shortage count.
        /// </summary>
        [MessagePack.Key(6)]
        public int ShortageCount { get; init; }

        /// <summary>
        /// Adjustment id.
        /// </summary>
        [MessagePack.Key(7)]
        public int? AdjustmentId { get; init; }

        /// <summary>
        /// Inbound id.
        /// </summary>
        [MessagePack.Key(8)]
        public int? InboundId { get; init; }

        /// <summary>
        /// Shift id.
        /// </summary>
        [MessagePack.Key(9)]
        public int? ShiftId { get; init; }

        /// <summary>
        /// Register id.
        /// </summary>
        [MessagePack.Key(10)]
        public int? RegisterId { get; init; }

        /// <summary>
        /// Operator id.
        /// </summary>
        [MessagePack.Key(11)]
        public int? OperatorId { get; init; }   
    }
}
