using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Register.
    /// </summary>
    [DataContract]
    [Serializable]
    public class RegisterModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The number of the register.
        /// </summary>
        [DataMember]
        [Required]
        public int Number { get; set; }

        /// <summary>
        /// The name of the register.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// The MAC address of the register.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string MacAddress { get; set; }

        /// <summary>
        /// The start cash of the register.
        /// </summary>
        [DataMember]
        [Range(0, double.MaxValue)]
        public decimal StartCash { get; set; }

        /// <summary>
        /// The idle timeout of the register.
        /// </summary>
        [DataMember]
        public int? IdleTimeout { get; set; }

        #endregion
    }
}
