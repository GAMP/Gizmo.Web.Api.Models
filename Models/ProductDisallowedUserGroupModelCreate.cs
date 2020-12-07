using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product disallowed user group.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ProductDisallowedUserGroupModelCreate : ProductDisallowedUserGroupModelBase, IUrlQueryParameters
    {
    }
}