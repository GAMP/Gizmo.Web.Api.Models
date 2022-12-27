using MessagePack;

using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.MonetaryUnit
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
