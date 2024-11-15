namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc cref="IStockModel"/>
    [MessagePack.MessagePackObject()]
    public class StockModel : IStockModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public string Name { get; init; } = null!;

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public StockType Type { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public int? BranchId { get; init; }
    }
}
