#nullable enable

using Gizmo.Web.Api.Models;
using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host.
    /// </summary>
    [MessagePackObject]
    public sealed class HostModelUpdate : IHostApiModel, IApiModelIdentifier, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the host group this host belongs to.
        /// </summary>
        [MessagePack.Key(1)]
        public int? HostGroupId { get; set; }

        /// <summary>
        /// The number of the host.
        /// </summary>
        [MessagePack.Key(2)]
        public int Number { get; set; }

        /// <summary>
        /// The name of the host.
        /// </summary>
        [MessagePack.Key(3)]
        [Required]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Host is out of order.
        /// </summary>
        [MessagePack.Key(4)]
        public bool IsOutOfOrder { get; set; }

        /// <summary>
        /// Host is locked.
        /// </summary>
        [MessagePack.Key(5)]
        public bool IsLocked { get; set; }

        /// <summary>
        /// The Id of the host icon this host is associated with.
        /// </summary>
        [MessagePack.Key(6)]
        public int? IconId { get; set; }

        /// <summary>
        /// Whether the host is deleted.
        /// </summary>
        [MessagePack.Key(7)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// The host computer object attached to this host if the host is a computer, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(8)]
        public HostComputer? HostComputer { get; set; } //TODO: Is required?

        /// <summary>
        /// The host endpoint object attached to this host if the host is an endpoint, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(9)]
        public HostEndpoint? HostEndpoint { get; set; } //TODO: Is required?

        #endregion
    }
}