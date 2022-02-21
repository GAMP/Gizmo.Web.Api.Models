using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Bundled product.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class BundledProductModelCreate : BundledProductModelBase, IUrlQueryParameters
    {
    }
}