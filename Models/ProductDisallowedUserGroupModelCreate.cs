using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    [Serializable]
    [DataContract]
    public class ProductDisallowedUserGroupModelCreate : ProductDisallowedUserGroupModelBase, IUrlQueryParameters
    {
        public string ToQueryParameters()
        {
            return ParameterGenerator.Generate(this);
        }
    }
}