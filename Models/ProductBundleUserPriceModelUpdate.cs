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
    public class ProductBundleUserPriceModelUpdate : ProductBundleUserPriceModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        #endregion
    }
}