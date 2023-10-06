namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Shift strt model.
    /// </summary>
    public interface IShiftStartModel
    {
        /// <summary>
        /// Register id.
        /// </summary>
        int RegisterId { get; }

        /// <summary>
        /// Start cash.
        /// </summary>
        decimal StartCash { get; init; }
    }
}
