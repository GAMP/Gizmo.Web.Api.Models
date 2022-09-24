using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host group.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class HostGroupModelCreate : HostGroupModelBase, IUrlQueryParameters
    {
    }
}