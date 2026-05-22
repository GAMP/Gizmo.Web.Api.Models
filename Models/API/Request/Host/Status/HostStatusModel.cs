using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host status model returned by the host status endpoint.
    /// </summary>
    [MessagePackObject]
    public sealed class HostStatusModel : IWebApiModel
    {
        /// <summary>
        /// Host id.
        /// </summary>
        [Key(0)]
        public int HostId { get; init; }

        /// <summary>
        /// Display number.
        /// </summary>
        [Key(1)]
        public int Number { get; init; }

        /// <summary>
        /// Display name.
        /// </summary>
        [Key(2)]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Host group id.
        /// </summary>
        [Key(3)]
        public int? HostGroupId { get; init; }

        /// <summary>
        /// Host group name.
        /// </summary>
        [Key(4)]
        public string? HostGroupName { get; init; }

        /// <summary>
        /// Layout row position.
        /// </summary>
        [Key(5)]
        public int Row { get; init; }

        /// <summary>
        /// Layout column position.
        /// </summary>
        [Key(6)]
        public int Column { get; init; }

        /// <summary>
        /// Indicates host is locked.
        /// </summary>
        [Key(7)]
        public bool IsLocked { get; init; }

        /// <summary>
        /// Indicates host is out of order.
        /// </summary>
        [Key(8)]
        public bool IsOutOfOrder { get; init; }

        /// <summary>
        /// Indicates host is in maintenance mode.
        /// </summary>
        [Key(9)]
        public bool IsInMaintenance { get; init; }

        /// <summary>
        /// Indicates host computer is currently connected.
        /// </summary>
        [Key(10)]
        public bool IsConnected { get; init; }

        /// <summary>
        /// The layout group id this host belongs to in the resolved layout.
        /// </summary>
        [Key(11)]
        public int LayoutGroupId { get; init; }

        /// <summary>
        /// Active sessions on this host. Empty indicates no users logged in.
        /// </summary>
        [Key(12)]
        public IEnumerable<HostStatusSessionModel> Sessions { get; init; } = [];
    }
}
