using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host layout group.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class HostLayoutGroupModelCreate : HostLayoutGroupModelBase, IUrlQueryParameters
    {
    }
}