using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Bundled product user price.
    /// </summary>
    [Serializable]
    [DataContract]
    public class BundledProductUserPriceModelBase : ProductUserPriceBase
    {
    }
}