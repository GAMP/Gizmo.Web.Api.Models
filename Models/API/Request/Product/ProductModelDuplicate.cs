using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product duplicate.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductModelDuplicate
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the new product.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        [StringLength(45)]
        public string NewName { get; set; } = null!;

        /// <summary>
        /// The barcode of the new product.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(255)]
        public string? NewBarcode { get; set; }

        #endregion
    }
}
