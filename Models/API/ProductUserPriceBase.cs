using MessagePack;
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
    [MessagePackObject]
    public class ProductUserPriceBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the user group this user price is associated with.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(0)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// The price for this user price.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public decimal? Price { get; set; }

        #endregion
    }
}