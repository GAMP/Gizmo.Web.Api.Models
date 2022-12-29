using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Line product.
    /// </summary>
    [MessagePackObject]
    public sealed class LineProduct : IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the product.
        /// </summary>
        [Key(0)]
        public int ProductId { get; set; }

        #endregion
    }
}
