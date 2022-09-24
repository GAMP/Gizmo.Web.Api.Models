using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Register transaction.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class RegisterTransactionModelCreate : RegisterTransactionModelBase
    {
    }
}