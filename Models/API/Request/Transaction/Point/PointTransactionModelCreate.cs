using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Transaction.Point
{
    /// <summary>
    /// Point transaction creation model.
    /// </summary>
    [Serializable()]
    [MessagePackObject()]
    public class PointTransactionModelCreate : PointTransactionModelBase
    {
    }
}
