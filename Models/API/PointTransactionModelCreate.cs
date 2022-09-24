using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
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
