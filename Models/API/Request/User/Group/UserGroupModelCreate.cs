using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.User.Group
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