using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Bundled product.
    /// </summary>
    [Serializable]
    [DataContract]
    public class BundledProductModelCreate : BundledProductModelBase, IUrlQueryParameters
    {
        public string ToQueryParameters()
        {
            return ParameterGenerator.Generate(this);
        }
    }
}