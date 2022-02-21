using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application group application.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ApplicationGroupApplication : ApplicationGroupApplicationModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the application group.
        /// </summary>
        [DataMember]
        public int ApplicationGroupId { get; set; }

        #endregion
    }
}
