using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Asset transaction information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AssetTransactionDTOModel
    {
        /// <summary>
        /// Asset type.
        /// </summary>
        [MessagePack.Key(0)]
        public string AssetType { get; set; } = string.Empty;

        /// <summary>
        /// Asset number.
        /// </summary>
        [MessagePack.Key(1)]
        public int AssetNumber { get; set; }

        /// <summary>
        /// Asset name.
        /// </summary>
        [MessagePack.Key(2)]
        public string AssetName { get; set; } = string.Empty;

        /// <summary>
        /// Customer name.
        /// </summary>
        [MessagePack.Key(3)]
        public string Customer { get; set; } = string.Empty;

        /// <summary>
        /// The time the asset was checked out.
        /// </summary>
        [MessagePack.Key(4)]
        public DateTime CheckOutTime { get; set; }

        /// <summary>
        /// Name of the operator that checked out the asset.
        /// </summary>
        [MessagePack.Key(5)]
        public string CheckOutOperator { get; set; } = string.Empty;

        /// <summary>
        /// The time the asset was checked in or null if is still checked out.
        /// </summary>
        [MessagePack.Key(6)]
        public DateTime? CheckInTime { get; set; }

        /// <summary>
        /// Name of the operator that checked in the asset.
        /// </summary>
        [MessagePack.Key(7)]
        public string CheckInOperator { get; set; } = string.Empty;

        /// <summary>
        /// Duration of the lease as text.
        /// </summary>
        [MessagePack.Key(8)]
        public string LeaseDuration { get; set; } = string.Empty;
    }
}
