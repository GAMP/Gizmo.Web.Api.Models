using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host.
    /// </summary>
    [Serializable]
    [DataContract]
    public class HostModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the host group this host belongs to.
        /// </summary>
        [DataMember]
        public int? HostGroupId { get; set; }

        /// <summary>
        /// The number of the host.
        /// </summary>
        [DataMember]
        [Required]
        public int Number { get; set; }

        /// <summary>
        /// The name of the host.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// Default state.
        /// </summary>
        public bool IsInOrder { get; set; }

        /// <summary>
        /// Host is out of order.
        /// </summary>
        public bool IsOutOfOrder { get; set; }

        /// <summary>
        /// Host is locked.
        /// </summary>
        public bool IsLocked { get; set; }

        /// <summary>
        /// The Id of the host icon this host is associated with.
        /// </summary>
        [DataMember]
        public int? IconId { get; set; }

        /// <summary>
        /// Whether the host is deleted.
        /// </summary>
        [DataMember]
        [Required]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// The host computer object attached to this host if the host is a computer, otherwise it will be null.
        /// </summary>
        [DataMember]
        public HostComputer HostComputer { get; set; }

        /// <summary>
        /// The host endpoint object attached to this host if the host is an endpoint, otherwise it will be null.
        /// </summary>
        [DataMember]
        public HostEndpoint HostEndpoint { get; set; }

        #endregion
    }
}