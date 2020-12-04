using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product bundle user price.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ProductBundleUserPriceModelUpdate : ProductBundleUserPriceModelBase, IEntityBase, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the bundled product this user price is associated with.
        /// </summary>
        [DataMember]
        [Required]
        public int BundledProduct { get; set; }

        #endregion

        public string ToQueryParameters()
        {
            return ParameterGenerator.Generate(this);
        }
    }
}