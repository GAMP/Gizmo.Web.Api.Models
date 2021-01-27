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
        /// Gets or sets personal user file id.
        /// </summary>
        [DataMember]
        [Required]
        public int PersonalFileId { get; set; }

        /// <summary>
        /// Gets or sets order.
        /// </summary>
        [DataMember]
        public int UseOrder { get; set; }

        #endregion
    }
}