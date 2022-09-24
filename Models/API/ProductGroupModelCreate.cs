using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
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