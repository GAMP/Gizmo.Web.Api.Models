using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Deposit transaction.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class DepositTransactionModelCreate : DepositTransactionModelBase
    {
        /// <summary>
        /// Whether to override the receipt.
        /// </summary>
        [DataMember]
        [MessagePack.Key(100)]
        public bool ReceiptOverride { get; set; }
    }
}