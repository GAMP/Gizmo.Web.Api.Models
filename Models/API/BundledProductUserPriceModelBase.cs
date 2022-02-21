using MessagePack;
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
    [MessagePackObject]
    public class BundledProductUserPriceModelBase : ProductUserPriceBase
    {
    }
}