using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.Image
{
    /// <summary>
    /// Product image.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductImageModelCreate : ProductImageModelBase, IUrlQueryParameters
    {
    }
}