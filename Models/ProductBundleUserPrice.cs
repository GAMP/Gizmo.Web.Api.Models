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
    public class ProductBundleUserPrice : ProductUserPriceBase
    {
        #region PROPERTIES

        [DataMember]
        [Required]
        public int BundleProduct { get; set; }

        #endregion
    }
}