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
    public sealed class RegisterModel : IRegisterModel, IModelIntIdentifier
    {
        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The number of the register.
        /// </summary>
        [MessagePack.Key(1)]
        public int Number { get; set; }

        /// <summary>
        /// The name of the register.
        /// </summary>
        [MessagePack.Key(2)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The start cash of the register.
        /// </summary>
        [MessagePack.Key(3)]
        [Range(0.0, 1_000_000_000_000)]
        public decimal StartCash { get; set; }

        /// <summary>
        /// The idle timeout of the register.
        /// </summary>
        [MessagePack.Key(4)]
        public int? IdleTimeout { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public int? PaymentTerminalNumber { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(6)]
        public int? FiscalReceiptPrinterNumber { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(7)]
        public int? StockId { get; init; }

        /// <summary>
        /// Deleted status.
        /// </summary>
        [MessagePack.Key(8)]
        public bool IsDeleted
        {
            get; set;
        }

        /// <inheritdoc/>
        [MessagePack.Key(9)]
        public int? CompanionId { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(10)]
        public int BranchId { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(11)]
        public int? QrDisplayNumber { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(12)]
        public bool IsDefault { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(13)]
        public bool IsGlobalDefault { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(14)]
        public int? ReceiptPrinterNumber { get; init; }
    }
}
