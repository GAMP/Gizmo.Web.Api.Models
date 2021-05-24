using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Register transaction.
    /// </summary>
    [DataContract]
    [Serializable]
    public class RegisterTransactionModelBase
    {
        /// <summary>
        /// The type of the register transaction.
        /// </summary>
        [DataMember]
        [EnumValue]
        public RegisterTransactionType Type { get; set; }

        /// <summary>
        /// The amount of the register transaction.
        /// </summary>
        [DataMember]
        public decimal Amount { get; set; }

        /// <summary>
        /// The note of the register transaction.
        /// </summary>
        [DataMember]
        public string Note { get; set; }
    }
}