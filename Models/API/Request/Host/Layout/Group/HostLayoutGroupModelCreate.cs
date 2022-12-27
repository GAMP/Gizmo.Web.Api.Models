using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Host.Layout.Group
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