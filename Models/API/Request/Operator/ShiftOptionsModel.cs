namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Shift options model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ShiftOptionsModel : IWebApiModel
    {
        /// <summary>
        /// Gets shift options.
        /// </summary>
        [MessagePack.Key(0)]
        public ShiftOptions Options
        {
            get; init;
        }
    }
}
