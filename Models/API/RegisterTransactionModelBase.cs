using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Register transaction.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class RegisterTransactionModelBase
    {
        #region PROPERTIES
        
        /// <summary>
        /// The type of the register transaction.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(0)]
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