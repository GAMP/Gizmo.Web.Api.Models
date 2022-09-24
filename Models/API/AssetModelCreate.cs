using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Asset.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class AssetModelCreate : AssetModelBase, IUrlQueryParameters
    {
    }
}