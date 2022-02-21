using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Asset type.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class AssetTypeModelCreate : AssetTypeModelBase, IUrlQueryParameters
    {
    }
}