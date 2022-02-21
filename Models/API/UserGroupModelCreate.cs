using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User group.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class UserGroupModelCreate : UserGroupModelBase, IUrlQueryParameters
    {
    }
}