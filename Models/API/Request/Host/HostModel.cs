using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base host model used for polymorphism.
    /// </summary>
    [MessagePack.Union((int)HostType.Computer, typeof(HostComputerModel))]
    [MessagePack.Union((int)HostType.Endpoint, typeof(HostEndpointModel))]
    public abstract class HostModel : IWebApiModel
    {
    }

    /// <summary>
    /// Computer host model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class HostComputerModel : HostModel, IModelIntIdentifier, IHostModelV3
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

        /// <summary>
        /// Client module version.
        /// </summary>
        [MessagePack.Key(12)]
        public string? ModuleVersion { get; init; }
    }

    /// <summary>
    /// Endpoint host model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class HostEndpointModel : HostModel, IModelIntIdentifier, IHostModelV3
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
