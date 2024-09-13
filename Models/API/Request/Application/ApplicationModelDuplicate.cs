using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application duplicate.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationModelDuplicate
    {
        #region PROPERTIES

        /// <summary>
        /// The title of the new executable.
        /// </summary>
        [MessagePack.Key(0)]
        public string NewTitle { get; set; } = null!;

        #endregion
    }
}
