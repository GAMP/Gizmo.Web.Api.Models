using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Register.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class RegisterModelCreate : IRegisterModel, IUriParametersQuery
    {
        #region PROPERTIES

        ///<inheritdoc/>
        [MessagePack.Key(0)]
        public int Number { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(1)]
        [StringLength(45)]
        public string Name { get; init; } = null!;

        ///<inheritdoc/>
        [MessagePack.Key(2)]
        [Range(0.0, 1_000_000_000_000)]
        public decimal StartCash { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(3)]
        public int? IdleTimeout { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(4)]
        public int? PaymentTerminalNumber { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(5)]
        public int? FiscalReceiptPrinterNumber { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(6)]
        public int? StockId { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(7)]
        public int? CompanionId { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(8)]
        public int BranchId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(9)]
        public int? QrDisplayNumber { get; set; }

        #endregion
    }
}
