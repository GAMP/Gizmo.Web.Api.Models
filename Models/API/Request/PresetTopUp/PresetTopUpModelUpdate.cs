using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Preset top up update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PresetTopUpModelUpdate : IPresetTopUpModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public decimal Value { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public int DisplayOrder { get; init; }
    }
}
