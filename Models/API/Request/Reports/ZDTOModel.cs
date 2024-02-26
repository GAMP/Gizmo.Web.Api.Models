using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Z's Information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class ZDTOModel
    {
        /// <summary>
        /// Incremental number of the Z.
        /// </summary>
        [MessagePack.Key(0)]
        public int ZId { get; set; }

        /// <summary>
        /// The time of the first Z transaction.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime OpenTime { get; set; }

        /// <summary>
        /// The time the Z was closed.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime CloseTime { get; set; }

        /// <summary>
        /// The Id of the first invoice within the Z.
        /// </summary>
        [MessagePack.Key(3)]
        public int FirstInvoiceId { get; set; }

        /// <summary>
        /// The Id of the last invoice within the Z.
        /// </summary>
        [MessagePack.Key(4)]
        public int LastInvoiceId { get; set; }

        /// <summary>
        /// Number of invoices within the Z.
        /// </summary>
        [MessagePack.Key(5)]
        public int InvoiceCount { get; set; }

        /// <summary>
        /// Number of items within the Z.
        /// </summary>
        [MessagePack.Key(6)]
        public int ItemCount { get; set; }

        /// <summary>
        /// Z's total tax.
        /// </summary>
        [MessagePack.Key(7)]
        public decimal TotalTax { get; set; }

        /// <summary>
        /// Z's total value.
        /// </summary>
        [MessagePack.Key(8)]
        public decimal TotalValue { get; set; }
    }
}
