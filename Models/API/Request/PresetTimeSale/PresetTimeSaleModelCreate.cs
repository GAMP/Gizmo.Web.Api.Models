namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Preset time sale create model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PresetTimeSaleModelCreate : IWebApiModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Value { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public int DisplayOrder { get; init; }
    }
}
