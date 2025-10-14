namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product order line mark model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ProductOrderLineMarkModel : IWebApiModel
    {
        /// <summary>
        /// Product order line id.
        /// </summary>
        [MessagePack.Key(0)]
        public int ProductOrderLineId { get; init; }

        /// <summary>
        /// Mark.
        /// </summary>
        /// <remarks>
        /// The value can be null to clear the mark.
        /// </remarks>
        [MessagePack.Key(1)]
        public string? Mark { get; init; }
    }
}
