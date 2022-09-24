using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable task.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationExecutableTaskModelUpdate : ApplicationExecutableTaskModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the executable this task is associated with.
        /// </summary>
        [Required]
        [MessagePack.Key(100)]
        public int ApplicationExecutableId { get; set; }

        #endregion
    }
}
