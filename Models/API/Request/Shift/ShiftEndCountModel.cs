namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// <inheritdoc cref="IShiftEndCountModel"/>
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ShiftEndCountModel : IWebApiModel, IShiftEndCountModel
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        public int PaymentMethodId { get; init; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(1)]
        public decimal Actual { get; init; }
    }
}
