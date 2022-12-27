using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Host.Group
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