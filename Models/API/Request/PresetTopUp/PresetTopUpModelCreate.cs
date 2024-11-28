namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Preset top up create model.
    /// </summary>
    public sealed class PresetTopUpModelCreate : IPresetTopUpModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public decimal Value { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public int DisplayOrder { get; init; }
    }
}
