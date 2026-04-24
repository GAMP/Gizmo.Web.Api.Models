using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host host layout group.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class HostHostLayoutGroupModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the host layout group.
        /// </summary>
        [MessagePack.Key(0)]
        public int HostLayoutGroupId { get; init; }

        /// <summary>
        /// The host is hidden from this layout.
        /// </summary>
        [MessagePack.Key(1)]
        public bool IsHidden { get; init; }

        #endregion
    }
}
