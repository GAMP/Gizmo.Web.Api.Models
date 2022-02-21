using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User attribute.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class UserAttributeModelCreate : UserAttributeModelBase, IUrlQueryParameters
    {
    }
}
