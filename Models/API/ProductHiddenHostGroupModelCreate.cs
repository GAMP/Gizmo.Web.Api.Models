using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product hidden host group.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ProductHiddenHostGroupModelCreate : ProductHiddenHostGroupModelBase, IUrlQueryParameters
    {
    }
}
