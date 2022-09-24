using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User group disallowed host group.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class UserGroupDisallowedHostGroupModelCreate : UserGroupDisallowedHostGroupModelBase, IUrlQueryParameters
    {
    }
}