using Gizmo.Web.Api.Models.Abstractions;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Asset transaction.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class AssetTransactionModel : IAssetTransactionModel, IModelIntIdentifier
    {
        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The date that the asset transaction was created.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the asset type the associated asset belongs to.
        /// </summary>
        [MessagePack.Key(2)]
        public int AssetTypeId { get; set; }

        /// <summary>
        /// The Id of the asset this asset transaction is associated with.
        /// </summary>
        [MessagePack.Key(3)]
        public int AssetId { get; set; }

        /// <summary>
        /// Whether the asset transaction is deleted.
        /// </summary>
        [MessagePack.Key(4)]
        public bool IsActive { get; set; }

        /// <summary>
        /// The Id of the operator who checked in the asset.
        /// </summary>
        [MessagePack.Key(5)]
        public int? CheckInOperatorId { get; set; }

        /// <summary>
        /// The date that the asset was checked in.
        /// </summary>
        [MessagePack.Key(6)]
        public DateTime? CheckInTime { get; set; }

        /// <summary>
        /// The Id of the operator who checked out the asset.
        /// </summary>
        [MessagePack.Key(7)]
        public int? CheckOutOperatorId { get; set; }

        /// <summary>
        /// The Id of the shift that the asset transaction belongs.
        /// </summary>
        [MessagePack.Key(8)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register on which the asset transaction was performed.
        /// </summary>
        [MessagePack.Key(9)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// The name of the asset type.
        /// </summary>
        [MessagePack.Key(10)]
        public string? AssetTypeName { get; set; }

        /// <summary>
        /// The Id of the user who checked out the asset.
        /// </summary>
        [MessagePack.Key(11)]
        public int UserId { get; set; }
    }
}
