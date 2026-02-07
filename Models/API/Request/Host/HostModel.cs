using System;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host.
    /// </summary>
    [Serializable, MessagePack.MessagePackObject]
    public sealed class HostModel : IHostModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The type of the host.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(1)]
        public HostType HostType { get; set; }

        /// <summary>
        /// The Id of the host group this host belongs to.
        /// </summary>
        [MessagePack.Key(2)]
        public int? HostGroupId { get; set; }

        /// <summary>
        /// The number of the host.
        /// </summary>
        [MessagePack.Key(3)]
        public int Number { get; set; }

        /// <summary>
        /// The name of the host.
        /// </summary>
        [MessagePack.Key(4)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Host is out of order.
        /// </summary>
        [MessagePack.Key(5)]
        public bool IsOutOfOrder { get; set; }

        /// <summary>
        /// Host is locked.
        /// </summary>
        [MessagePack.Key(6)]
        public bool IsLocked { get; set; }

        /// <summary>
        /// The Id of the host icon this host is associated with.
        /// </summary>
        [MessagePack.Key(7)]
        public int? IconId { get; set; }

        /// <summary>
        /// Whether the host is deleted.
        /// </summary>
        [MessagePack.Key(8)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// The host computer object attached to this host if the host is a computer, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(9)]
        public HostModelComputer? HostComputer { get; set; }

        /// <summary>
        /// The host endpoint object attached to this host if the host is an endpoint, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(10)]
        public HostModelEndpoint? HostEndpoint { get; set; }

        #endregion
    }

    /// <summary>
    /// Base host model used for polymorphism.
    /// </summary>
    [MessagePack.Union((int)HostType.Computer, typeof(HostComputerModel))]
    [MessagePack.Union((int)HostType.Endpoint, typeof(HostEndpointModel))]
    public abstract class HostModelV3 : IWebApiModel
    {

    }

    /// <summary>
    /// Computer host model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class HostComputerModel : HostModelV3, IModelIntIdentifier, IHostModelV3
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public int? HostGroupId { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public int Number { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public required string Name { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public bool IsOutOfOrder { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public bool IsLocked { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(6)]
        public int? IconId { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(7)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// The windows name of the computer.
        /// </summary>
        [MessagePack.Key(8)]
        public string WindowsName { get; set; } = null!;

        /// <summary>
        /// The MAC Address of the computer.
        /// </summary>
        [MessagePack.Key(9)]
        [MacAddressValidation]
        public required string MacAddress { get; set; } = null!;

        /// <summary>
        /// Indicates that host is secure.
        /// </summary>
        [MessagePack.Key(10)]
        public bool IsSecure { get; init; }

        /// <summary>
        /// Indicates that host in maintenance mode.
        /// </summary>
        [MessagePack.Key(11)]
        public bool IsInMaintenance { get; init; }
    }

    /// <summary>
    /// Endpoint host model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class HostEndpointModel : HostModelV3, IModelIntIdentifier, IHostModelV3
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public int? HostGroupId { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public int Number { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public required string Name { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public bool IsOutOfOrder { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public bool IsLocked { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(6)]
        public int? IconId { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(7)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// The maximum number of users the endpoint can host.
        /// </summary>
        [MessagePack.Key(8)]
        public int MaximumUsers { get; set; }
    }
}
