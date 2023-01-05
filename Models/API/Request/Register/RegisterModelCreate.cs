#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Register.
    /// </summary>
    [MessagePackObject]
    public sealed class RegisterModelCreate : IRegisterApiModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The number of the register.
        /// </summary>
        [MessagePack.Key(0)]
        public int Number { get; set; }

        /// <summary>
        /// The name of the register.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The MAC address of the register.
        /// </summary>
        [MessagePack.Key(2)]
        [StringLength(255)]
        [MacAddressValidation]
        public string? MacAddress { get; set; }

        /// <summary>
        /// The start cash of the register.
        /// </summary>
        [MessagePack.Key(3)]
        [Range(0, double.MaxValue)]
        public decimal StartCash { get; set; } //TODO: Double?

        /// <summary>
        /// The idle timeout of the register.
        /// </summary>
        [MessagePack.Key(4)]
        public int? IdleTimeout { get; set; }

        #endregion
    }
}
