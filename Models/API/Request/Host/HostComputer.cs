using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Host
{
    /// <summary>
    /// Host computer.
    /// </summary>
    [MessagePackObject]
    public sealed class HostComputer
    {
        #region PROPERTIES

        /// <summary>
        /// The windows name of the computer.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        public string WindowsName { get; set; }

        /// <summary>
        /// The MAC Address of the computer.
        /// </summary>
        [MessagePack.Key(1)]
        [Required]
        [MacAddressValidation]
        public string MacAddress { get; set; }

        #endregion
    }
}
