using MessagePack;
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
    [MessagePackObject]
    public class ApplicationTaskScript
    {
        #region PROPERTIES

        /// <summary>
        /// The type of the script.
        /// </summary>
        [DataMember]
        [EnumValue]
        public ScriptTypes ScriptType { get; set; }

        /// <summary>
        /// The data of the script.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(65535)]
        public string Data { get; set; }

        /// <summary>
        /// Whether the script is awaited until exit.
        /// </summary>
        [DataMember]
        public bool Wait { get; set; }

        /// <summary>
        /// Whether the script is invisible.
        /// </summary>
        [DataMember]
        public bool NoWindow { get; set; }

        #endregion
    }
}