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
    public class ApplicationExecutablePersonalFile : ApplicationExecutablePersonalFileModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the executable this personal file is associated with.
        /// </summary>
        [DataMember]
        public int ApplicationExecutableId { get; set; }

        #endregion
    }
}
