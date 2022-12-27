using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.Group
{
    /// <summary>
    /// Product group.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductGroupModelCreate : ProductGroupModelBase, IUrlQueryParameters
    {
    }
}