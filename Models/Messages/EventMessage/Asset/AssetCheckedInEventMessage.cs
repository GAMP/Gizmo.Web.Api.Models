using System;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Asset checked in event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Checked in", "ASSET_CHECKED_IN_EVENT_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates asset being checked in", "ASSET_CHECKED_IN_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class AssetCheckedInEventMessage : AssetEventMessageBase
    {
        /// <inheritdoc/>
        public AssetCheckedInEventMessage() : base() { }

        /// <summary>
        /// Asset id.
        /// </summary>
        [MessagePack.Key(1)]
        public int AssetId { get; init; }

        /// <summary>
        /// Asset type id.
        /// </summary>
        [MessagePack.Key(2)]
        public int AssetTypeId { get; init; }

        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(3)]
        public int UserId { get; init; }

        /// <summary>
        /// Event time.
        /// </summary>
        [MessagePack.Key(4)]
        public DateTime Time { get; init; }
    }
}
