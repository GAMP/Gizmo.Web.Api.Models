using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Attribute.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class AttributeModelCreate : AttributeModelBase, IUrlQueryParameters
    {
    }
}