using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application task.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ApplicationTaskModelCreate : ApplicationTaskModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The type of the application task.
        /// </summary>
        [DataMember]
        [EnumValue]
        public TaskType TaskType { get; set; }

        #endregion
    }
}
