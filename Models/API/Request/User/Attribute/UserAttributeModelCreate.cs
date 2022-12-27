using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.User.Attribute
{
    /// <summary>
    /// User attribute.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class UserAttributeModelCreate : UserAttributeModelBase, IUrlQueryParameters
    {
    }
}
