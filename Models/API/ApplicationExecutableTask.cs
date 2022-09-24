using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable task.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationExecutableTask : ApplicationExecutableTaskModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the application executable.
        /// </summary>
        [Key(100)]
        public int ApplicationExecutableId { get; set; }

        #endregion
    }
}