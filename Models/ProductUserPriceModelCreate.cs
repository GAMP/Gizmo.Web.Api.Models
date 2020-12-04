using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product user price.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ProductUserPriceModelCreate : ProductUserPriceModelBase, IUrlQueryParameters
    {
        public string ToQueryParameters()
        {
            return ParameterGenerator.Generate(this);
        }
    }
}