using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Attribute.
    /// </summary>
    [DataContract]
    [Serializable]
    public class AttributeModelCreate : AttributeModelBase, IUrlQueryParameters
    {
    }
}