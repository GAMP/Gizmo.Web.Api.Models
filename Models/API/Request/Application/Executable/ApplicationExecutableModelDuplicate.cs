using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable duplicate.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationExecutableModelDuplicate
    {
        #region PROPERTIES

        /// <summary>
        /// The caption of the new executable.
        /// </summary>
        [MessagePack.Key(0)]
        public string NewCaption { get; set; } = null!;

        #endregion
    }
}
