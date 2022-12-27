using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.HiddenHostGroup
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
