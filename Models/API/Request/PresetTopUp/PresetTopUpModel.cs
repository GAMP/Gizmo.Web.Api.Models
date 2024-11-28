using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Preset top up model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PresetTopUpModel : IWebApiModel, IModelIntIdentifier, IPresetTopUpModel
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
