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
    public class ApplicationExecutablePersonalFileModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the personal file associated with this application executable.
        /// </summary>
        [DataMember]
        [Required]
        public int PersonalFileId { get; set; }

        /// <summary>
        /// The order in which the personal file is used.
        /// </summary>
        [DataMember]
        public int UseOrder { get; set; }

        #endregion
    }
}