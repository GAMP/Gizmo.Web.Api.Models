using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application task script.
    /// </summary>
    [DataContract]
    [Serializable]
    public class ApplicationTaskScript
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets script type.
        /// </summary>
        [DataMember]
        public ScriptTypes ScriptType { get; set; }

        /// <summary>
        /// Gets or sets data.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(65535)]
        public string Data { get; set; }

        /// <summary>
        /// Wait.
        /// </summary>
        [DataMember]
        public bool Wait { get; set; }

        /// <summary>
        /// No window.
        /// </summary>
        [DataMember]
        public bool NoWindow { get; set; }

        #endregion
    }
}