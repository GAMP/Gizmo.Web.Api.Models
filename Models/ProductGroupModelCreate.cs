using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product group.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ProductGroupModelCreate : ProductGroupModelBase, IUrlQueryParameters
    {
        public string ToQueryParameters()
        {
            return ParameterGenerator.Generate(this);
        }
    }
}