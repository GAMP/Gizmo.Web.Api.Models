using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Host.Model
{
    /// <summary>
    /// Host.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class HostModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the host group this host belongs to.
        /// </summary>
        [MessagePack.Key(0)]
        public int? HostGroupId { get; set; }

        /// <summary>
        /// The number of the host.
        /// </summary>
        [Required]
        [MessagePack.Key(1)]
        public int Number { get; set; }

        /// <summary>
        /// The name of the host.
        /// </summary>
        [Required]
        [StringLength(45)]
        [MessagePack.Key(2)]
        public string Name { get; set; }

        /// <summary>
        /// Host is out of order.
        /// </summary>
        [MessagePack.Key(3)]
        public bool IsOutOfOrder { get; set; }

        /// <summary>
        /// Host is locked.
        /// </summary>
        [MessagePack.Key(4)]
        public bool IsLocked { get; set; }

        /// <summary>
        /// The Id of the host icon this host is associated with.
        /// </summary>
        [MessagePack.Key(5)]
        public int? IconId { get; set; }

        /// <summary>
        /// Whether the host is deleted.
        /// </summary>
        [MessagePack.Key(6)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// The host computer object attached to this host if the host is a computer, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(7)]
        public HostComputer HostComputer { get; set; }

        /// <summary>
        /// The host endpoint object attached to this host if the host is an endpoint, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(8)]
        public HostEndpoint HostEndpoint { get; set; }

        #endregion
    }
}