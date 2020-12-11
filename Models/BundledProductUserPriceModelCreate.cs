using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Bundled product user price.
    /// </summary>
    [Serializable]
    [DataContract]
    public class BundledProductUserPriceModelCreate : BundledProductUserPriceModelBase, IUrlQueryParameters
    {
    }
}