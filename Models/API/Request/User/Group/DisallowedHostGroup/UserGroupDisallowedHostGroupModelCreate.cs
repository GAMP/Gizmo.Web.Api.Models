using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.User.Group.DisallowedHostGroup
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