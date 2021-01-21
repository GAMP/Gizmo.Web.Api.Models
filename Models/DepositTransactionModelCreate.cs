using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Deposit transaction.
    /// </summary>
    [DataContract]
    [Serializable]
    public class DepositTransactionModelCreate : DepositTransactionModelBase
    {
        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        public int PaymentMethodId { get; set; }
    }
}