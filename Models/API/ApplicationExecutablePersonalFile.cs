using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable personal file.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ApplicationExecutablePersonalFile : ApplicationExecutablePersonalFileModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the application executable.
        /// </summary>
        [DataMember]
        public int ApplicationExecutableId { get; set; }

        #endregion
    }
}
