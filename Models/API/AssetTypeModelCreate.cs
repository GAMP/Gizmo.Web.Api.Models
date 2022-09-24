using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Asset type.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class AssetTypeModelCreate : AssetTypeModelBase, IUrlQueryParameters
    {
    }
}