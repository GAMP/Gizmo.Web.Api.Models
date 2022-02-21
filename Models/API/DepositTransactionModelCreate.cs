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
    }
}