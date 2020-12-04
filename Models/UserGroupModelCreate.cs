using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User group.
    /// </summary>
    [Serializable]
    [DataContract]
    public class UserGroupModelCreate : UserGroupModelBase, IUrlQueryParameters
    {
        public string ToQueryParameters()
        {
            return ParameterGenerator.Generate(this);
        }
    }
}