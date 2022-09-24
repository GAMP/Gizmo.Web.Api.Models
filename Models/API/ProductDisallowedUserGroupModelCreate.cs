using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product disallowed user group.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductDisallowedUserGroupModelCreate : ProductDisallowedUserGroupModelBase, IUrlQueryParameters
    {
    }
}