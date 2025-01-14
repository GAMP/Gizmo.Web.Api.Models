namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Preset time sale money create model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PresetTimeSaleMoneyModelCreate : IWebApiModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public decimal Value { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public int DisplayOrder { get; init; }
    }
}
