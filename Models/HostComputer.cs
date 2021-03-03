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
    public class HostComputer
    {
        #region PROPERTIES

        /// <summary>
        /// The windows name of the computer.
        /// </summary>
        [DataMember]
        [Required]
        public string WindowsName { get; set; }

        /// <summary>
        /// The MAC Address of the computer.
        /// </summary>
        [DataMember]
        [Required]
        [MacAddress]
        public string MacAddress { get; set; }

        #endregion
    }
}
