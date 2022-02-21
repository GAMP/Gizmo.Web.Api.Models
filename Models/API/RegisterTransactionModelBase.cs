using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Register transaction.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class RegisterTransactionModelBase
    {
        /// <summary>
        /// The type of the register transaction.
        /// </summary>
        [DataMember]
        [EnumValue]
        [MessagePack.Key(0)]
        public RegisterTransactionType Type { get; set; }

        /// <summary>
        /// The amount of the register transaction.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The note of the register transaction.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public string Note { get; set; }
    }
}