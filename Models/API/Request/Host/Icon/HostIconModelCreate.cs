using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Host.Icon
{
    /// <summary>
    /// Host icon.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class HostIconModelCreate : HostIconModelBase, IUrlQueryParameters
    {
    }
}
