using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Stock update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class StockUpdateModel : StockModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        public int Id { get; init; }
    }
}
