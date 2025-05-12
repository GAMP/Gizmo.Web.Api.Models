using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount group model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class DiscountGroupModel : IWebApiModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Discount group name.
        /// </summary>
        [MessagePack.Key(1)]
        public string Name { get; init; } = null!;
    }
}
