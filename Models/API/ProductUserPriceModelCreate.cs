using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product user price.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductUserPriceModelCreate : ProductUserPriceModelBase, IUrlQueryParameters
    {
    }
}