using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ProductModelUpdate : ProductModelBase, IEntityBase, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }
        
        #endregion

        public string ToQueryParameters()
        {
            return ParameterGenerator.Generate(this);
        }
    }
}