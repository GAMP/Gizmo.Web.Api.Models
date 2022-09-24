using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product hidden host group.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductHiddenHostGroupModelCreate : ProductHiddenHostGroupModelBase, IUrlQueryParameters
    {
    }
}
