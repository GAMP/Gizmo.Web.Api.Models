using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host computer.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class HostModelComputer
    {
        #region PROPERTIES

        /// <summary>
        /// The windows name of the computer.
        /// </summary>
        [MessagePack.Key(0)]
        public string WindowsName { get; set; } = null!;

        /// <summary>
        /// The MAC Address of the computer.
        /// </summary>
        [MessagePack.Key(1)]
        [MacAddressValidation]
        public string MacAddress { get; set; } = null!;

        /// <summary>
        /// Indicates that host is secure.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsSecure { get; init; }

        /// <summary>
        /// Indicates that host in maintenance mode.
        /// </summary>
        [MessagePack.Key(3)]
        public bool IsInMaintenance { get; init; }

        #endregion
    }
}
