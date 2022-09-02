using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host computer.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class HostComputer
    {
        #region PROPERTIES

        /// <summary>
        /// The windows name of the computer.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(0)]
        public string WindowsName { get; set; }

        /// <summary>
        /// The MAC Address of the computer.
        /// </summary>
        [DataMember]
        [Required]
        [MacAddress]
        [MessagePack.Key(1)]
        public string MacAddress { get; set; }

        #endregion
    }
}
