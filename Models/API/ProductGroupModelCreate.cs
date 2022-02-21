using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product group.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ProductGroupModelCreate : ProductGroupModelBase, IUrlQueryParameters
    {
    }
}