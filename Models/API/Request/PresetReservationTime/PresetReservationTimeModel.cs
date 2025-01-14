using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Preset reservation time model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PresetReservationTimeModel : IWebApiModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public int Value { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public int DisplayOrder { get; init; }
    }
}
