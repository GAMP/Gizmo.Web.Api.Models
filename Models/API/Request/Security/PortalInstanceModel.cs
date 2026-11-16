using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Portal instance this instance can be bound to.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PortalInstanceModel : IWebApiModel
    {
        /// <summary>
        /// Portal instance id.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid InstanceId { get; init; }

        /// <summary>
        /// Display name.
        /// </summary>
        [MessagePack.Key(1)]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Product name.
        /// </summary>
        [MessagePack.Key(2)]
        public string ProductName { get; init; } = string.Empty;
    }
}
