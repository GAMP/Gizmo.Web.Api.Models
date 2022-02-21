using MessagePack;
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
    [MessagePackObject]
    public class HostModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the host group this host belongs to.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public int? HostGroupId { get; set; }

        /// <summary>
        /// The number of the host.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(1)]
        public int Number { get; set; }

        /// <summary>
        /// The name of the host.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        [MessagePack.Key(2)]
        public string Name { get; set; }

        /// <summary>
        /// Host is out of order.
        /// </summary>
        [DataMember]
        [MessagePack.Key(3)]
        public bool IsOutOfOrder { get; set; }

        /// <summary>
        /// Host is locked.
        /// </summary>
        [DataMember]
        [MessagePack.Key(4)]
        public bool IsLocked { get; set; }

        /// <summary>
        /// The Id of the host icon this host is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(5)]
        public int? IconId { get; set; }

        /// <summary>
        /// Whether the host is deleted.
        /// </summary>
        [DataMember]
        [MessagePack.Key(6)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// The host computer object attached to this host if the host is a computer, otherwise it will be null.
        /// </summary>
        [DataMember]
        [MessagePack.Key(7)]
        public HostComputer HostComputer { get; set; }

        /// <summary>
        /// The host endpoint object attached to this host if the host is an endpoint, otherwise it will be null.
        /// </summary>
        [DataMember]
        [MessagePack.Key(8)]
        public HostEndpoint HostEndpoint { get; set; }

        #endregion
    }
}