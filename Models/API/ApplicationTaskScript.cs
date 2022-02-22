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
        [MessagePack.Key(0)]
        public ScriptTypes ScriptType { get; set; }

        /// <summary>
        /// The data of the script.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(65535)]
        [MessagePack.Key(1)]
        public string Data { get; set; }

        /// <summary>
        /// Whether the script is awaited until exit.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public bool Wait { get; set; }

        /// <summary>
        /// Whether the script is invisible.
        /// </summary>
        [DataMember]
        [MessagePack.Key(3)]
        public bool NoWindow { get; set; }

        #endregion
    }
}