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
        /// Optional note.
        /// </summary>
        [MessagePack.Key(1)]
        public string? Note { get; init; }

        /// <summary>
        /// The number of expected entries.
        /// </summary>
        [MessagePack.Key(2)]
        public int UnexpectedEntries { get; init; }
    }
}
