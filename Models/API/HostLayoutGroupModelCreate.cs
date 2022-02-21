using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host layout group.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class HostLayoutGroupModelCreate : HostLayoutGroupModelBase, IUrlQueryParameters
    {
    }
}