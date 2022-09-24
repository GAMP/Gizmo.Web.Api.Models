using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User group.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class UserGroupModelCreate : UserGroupModelBase, IUrlQueryParameters
    {
    }
}