using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Transaction.Register
{
    /// <summary>
    /// Register transaction.
    /// </summary>
    [MessagePackObject]
    public sealed class RegisterTransactionModelCreate : IRegisterTransactionApiModel
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
        [MessagePack.Key(1)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The note of the register transaction.
        /// </summary>
        [MessagePack.Key(2)]
        public string Note { get; set; }

        #endregion
    }
}