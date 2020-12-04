using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    [Serializable]
    [DataContract]
    public class ProductDisallowedUserGroupModelUpdate : ProductDisallowedUserGroupModelBase, IEntityBase, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int Product { get; set; }

        #endregion

        public string ToQueryParameters()
        {
            return ParameterGenerator.Generate(this);
        }
    }
}