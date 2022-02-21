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
    public class RegisterTransactionModelCreate : RegisterTransactionModelBase
    {
    }
}