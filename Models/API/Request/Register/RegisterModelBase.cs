using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Register
{
    /// <summary>
    /// Register.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class RegisterModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The number of the register.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public int Number { get; set; }

        /// <summary>
        /// The name of the register.
        /// </summary>
        [Required]
        [StringLength(45)]
        [MessagePack.Key(1)]
        public string Name { get; set; }

        /// <summary>
        /// The MAC address of the register.
        /// </summary>
        [StringLength(255)]
        [MacAddressValidation]
        [MessagePack.Key(2)]
        public string MacAddress { get; set; }

        /// <summary>
        /// The start cash of the register.
        /// </summary>
        [Range(0, double.MaxValue)]
        [MessagePack.Key(3)]
        public decimal StartCash { get; set; }

        /// <summary>
        /// The idle timeout of the register.
        /// </summary>
        [MessagePack.Key(4)]
        public int? IdleTimeout { get; set; }

        #endregion
    }
}
