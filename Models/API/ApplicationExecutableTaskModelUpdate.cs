using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable task.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationExecutableTaskModelUpdate : ApplicationExecutableTaskModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the executable this task is associated with.
        /// </summary>
        [DataMember]
        [Required]
        public int ApplicationExecutableId { get; set; }

        #endregion
    }
}
