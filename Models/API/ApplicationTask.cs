using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application task.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ApplicationTask : ApplicationTaskModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// The type of the application task.
        /// </summary>
        [DataMember]
        [EnumValue]
        public TaskType TaskType { get; set; }

        /// <summary>
        /// The GUID of the product.
        /// </summary>
        [DataMember]
        public Guid Guid { get; set; }

        #endregion
    }
}
