using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time product disallowed host group.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class TimeProductDisallowedHostGroupModelCreate : TimeProductDisallowedHostGroupModelBase, IUrlQueryParameters
    {
    }
}