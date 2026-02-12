using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class BanLogModel : IBanLogModel
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(1)]
        public int UserId { get; init; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(2)]
        public UserMemberDisableEntryType Type { get; init; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(3)]
        public int? BanReasonId { get; init; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(4)]
        public string? Note { get; init; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(5)]
        public DateTime Time { get;init; }
    }
}
