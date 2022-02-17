using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User group disallowed host group.
    /// </summary>
    [Serializable]
    [DataContract]
    public class UserGroupDisallowedHostGroupModelCreate : UserGroupDisallowedHostGroupModelBase, IUrlQueryParameters
    {
    }
}