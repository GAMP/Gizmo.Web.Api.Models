using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable deployment.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationExecutableDeployment : ApplicationExecutableDeploymentModelBase
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
