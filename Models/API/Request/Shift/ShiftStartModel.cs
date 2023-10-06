namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// <inheritdoc cref="IShiftStartModel"/>
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ShiftStartModel : IWebApiModel, IShiftStartModel
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        public int RegisterId
        {
            get;init;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(1)]
        public decimal StartCash
        {
            get; init;
        }
    }
}
