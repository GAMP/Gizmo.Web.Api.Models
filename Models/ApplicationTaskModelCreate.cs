using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application task.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationTaskModelCreate : ApplicationTaskModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The type of the application task.
        /// </summary>
        [DataMember]
        public TaskType TaskType { get; set; }

        #endregion
    }
}
