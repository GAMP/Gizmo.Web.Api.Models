using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Bundled product user price.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class BundledProductUserPriceModelCreate : BundledProductUserPriceModelBase, IUrlQueryParameters
    {
    }
}