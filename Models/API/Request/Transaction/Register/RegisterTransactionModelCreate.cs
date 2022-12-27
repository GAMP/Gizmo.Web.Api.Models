using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Transaction.Register
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