using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User counters.
    /// </summary>
    [MessagePackObject]
    public sealed class UserCountersModel
    {
        #region PROPERTIES

        /// <summary>
        /// Checked out assets.
        /// </summary>
        [MessagePack.Key(0)]
        public int Assets { get; set; }

        /// <summary>
        /// Notes.
        /// </summary>
        [MessagePack.Key(1)]
        public int Notes { get; set; }

        #endregion
    }
}
