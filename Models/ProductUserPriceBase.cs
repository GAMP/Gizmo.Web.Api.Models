using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product user price base.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ProductUserPriceBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the user group this user price is associated with.
        /// </summary>
        [DataMember]
        [Required]
        public int UserGroupId { get; set; }

        /// <summary>
        /// The price for this user price.
        /// </summary>
        [DataMember]
        [Required]
        public decimal Price { get; set; }

        #endregion
    }
}