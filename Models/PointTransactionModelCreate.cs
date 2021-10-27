using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Point transaction creation model.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [MessagePackObject()]
    public class PointTransactionModelCreate : PointTransactionModelBase
    {
    }
}
