using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Tax.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class TaxModelCreate : TaxModelBase, IUrlQueryParameters
    {
    }
}
