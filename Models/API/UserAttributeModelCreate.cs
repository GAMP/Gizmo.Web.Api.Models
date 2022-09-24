using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
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
