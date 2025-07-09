using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Stock update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class StockModelUpdate : IStockModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public string Name { get; init; } = null!;

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public StockType Type { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public int? BranchId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public bool IsDeleted { get; set; }
    }
}
