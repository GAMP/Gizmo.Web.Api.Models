using System;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Register transaction.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class RegisterTransactionModelCreate : IRegisterTransactionModel
    {
        #region PROPERTIES

        /// <summary>
        /// The type of the register transaction.
        /// </summary>
        [MessagePack.Key(0)]
        [EnumValueValidation]
        public RegisterTransactionType Type { get; set; }

        /// <summary>
        /// The amount of the register transaction.
        /// </summary>
        /// <remarks>
        /// The minimum amount is 0.0001 (minimum amount our system can support), zero amount is practically invalid here.
        /// </remarks>
        [MessagePack.Key(1)]
        [Range(0.0001, double.MaxValue)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The note of the register transaction.
        /// </summary>
        [MessagePack.Key(2)]
        public string? Note { get; set; }

        /// <summary>
        /// Disable receipt printing for created transaction.
        /// </summary>
        [MessagePack.Key(3)]
        public bool DisableReceiptPrinting { get; set; }

        #endregion
    }
}
