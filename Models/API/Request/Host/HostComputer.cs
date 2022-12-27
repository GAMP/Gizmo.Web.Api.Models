using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Host
{
    /// <summary>
    /// Host computer.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class HostComputer
    {
        #region PROPERTIES

        /// <summary>
        /// The windows name of the computer.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public string WindowsName { get; set; }

        /// <summary>
        /// The MAC Address of the computer.
        /// </summary>
        [Required]
        [MacAddressValidation]
        [MessagePack.Key(1)]
        public string MacAddress { get; set; }

        #endregion
    }
}
