using System;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Register.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class RegisterModelUpdate : IRegisterModel, IModelIntIdentifier, IUriParametersQuery
    {
        ///<inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(1)]
        public int Number { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(2)]
        [StringLength(45)]
        public string Name { get; init; } = null!;

        ///<inheritdoc/>
        [MessagePack.Key(3)]
        [Range(0.0, 1_000_000_000_000)]
        public decimal StartCash { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(4)]
        public int? IdleTimeout { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(5)]
        public int? PaymentTerminalNumber { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(6)]
        public int? FiscalReceiptPrinterNumber { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(7)]
        public int? StockId { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(8)]
        public int? CompanionId { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(9)]
        public int BranchId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(10)]
        public int? QrDisplayNumber { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(11)]
        public bool IsDefault { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(12)]
        public bool IsGlobalDefault { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(13)]
        public int? ReceiptPrinterNumber { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(14)]
        public int? DefaultOperatorId { get; init; }
    }
}
