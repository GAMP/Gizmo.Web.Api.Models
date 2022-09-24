using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Bundled product.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class BundledProductModelCreate : BundledProductModelBase, IUrlQueryParameters
    {
    }
}