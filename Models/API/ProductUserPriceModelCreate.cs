using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product user price.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ProductUserPriceModelCreate : ProductUserPriceModelBase, IUrlQueryParameters
    {
    }
}