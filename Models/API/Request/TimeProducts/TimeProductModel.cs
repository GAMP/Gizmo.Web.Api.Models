using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time product.
    /// </summary>
    [MessagePackObject]
    public sealed class TimeProductModel
    {
        #region PROPERTIES

        [MessagePack.Key(0)]
        public int InvoiceId { get; set; }

        [MessagePack.Key(1)]
        public int InvoiceLineId { get; set; }

        [MessagePack.Key(2)]
        public string ProductName { get; set; }

        [MessagePack.Key(3)]
        public DateTime PurchaseDate { get; set; }

        [MessagePack.Key(4)]
        public double TotalSeconds { get; set; }

        [MessagePack.Key(5)]
        public double UsedSeconds { get; set; }

        [MessagePack.Key(6)]
        public bool ExpiresAtLogout { get; set; }

        [MessagePack.Key(7)]
        public DateTime? ExpiryDate { get; set; }

        [MessagePack.Key(8)]
        public bool IsPaid { get; set; }

        [MessagePack.Key(9)]
        public bool IsDepleted { get; set; }

        [MessagePack.Key(10)]
        public bool IsDeleted { get; set; }

        [MessagePack.Key(11)]
        public bool IsVoided { get; set; }

        [MessagePack.Key(12)]
        public bool IsExpired { get; set; }

        [MessagePack.Key(13)]
        public ProductTimeType Type { get; set; }

        #endregion
    }
}
