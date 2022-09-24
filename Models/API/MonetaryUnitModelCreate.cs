using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Monetary unit.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class MonetaryUnitModelCreate : MonetaryUnitModelBase, IUrlQueryParameters
    {
    }
}
