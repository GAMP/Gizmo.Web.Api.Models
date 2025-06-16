using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product group counters.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductGroupCountersModel
    {
        #region PROPERTIES

        /// <summary>
        /// Product group Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int ProductGroupId { get; set; }

        /// <summary>
        /// Total products within product group.
        /// </summary>
        [MessagePack.Key(1)]
        public int TotalProducts { get; set; }

        /// <summary>
        /// Total deleted products within user group.
        /// </summary>
        [MessagePack.Key(4)]
        public int DeletedProducts { get; set; }

        #endregion
    }
}
