using System;
using System.ComponentModel.DataAnnotations;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Requests a non-fiscal receipt print on the caller's effective register.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class NonFiscalReceiptPrintRequestModel
    {
        #region PROPERTIES

        /// <summary>
        /// The kind of receipt to print.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        [EnumValueValidation]
        public NonFiscalReceiptKind? Kind { get; set; }

        /// <summary>
        /// The identifier of the receipt entity.
        /// </summary>
        [MessagePack.Key(1)]
        [Range(1, int.MaxValue)]
        public int EntityId { get; set; }

        /// <summary>
        /// The number of copies to print.
        /// </summary>
        [MessagePack.Key(3)]
        [Range(1, 10)]
        public int Copies { get; set; }

        #endregion
    }
}
