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

        [DataMember]
        [Required]
        public string WindowsName { get; set; }

        [DataMember]
        [Required]
        public string MacAddress { get; set; }

        #endregion
    }
}
