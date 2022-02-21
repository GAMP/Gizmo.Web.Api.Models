using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application license.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ApplicationLicenseModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the license.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// The plugin type name of the license.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        [MessagePack.Key(1)]
        public string Plugin { get; set; }

        /// <summary>
        /// The plugin assembly of the license.
        /// </summary>        
        [DataMember]
        [Required]
        [StringLength(255)]
        [MessagePack.Key(2)]
        public string Assembly { get; set; }

        #endregion
    }
}