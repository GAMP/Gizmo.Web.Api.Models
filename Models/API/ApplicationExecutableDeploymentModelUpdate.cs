using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable deployment.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationExecutableDeploymentModelUpdate : ApplicationExecutableDeploymentModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the executable this deployment is associated with.
        /// </summary>
        [Required]
        [MessagePack.Key(100)]
        public int ApplicationExecutableId { get; set; }

        #endregion
    }
}
