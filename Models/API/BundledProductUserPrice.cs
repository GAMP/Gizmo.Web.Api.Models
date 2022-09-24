using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Bundled product user price.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class BundledProductUserPrice : BundledProductUserPriceModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(300)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the bundled product this user price is associated with.
        /// </summary>
        [Required]
        [MessagePack.Key(301)]
        public int BundledProductId { get; set; }

        #endregion
    }
}