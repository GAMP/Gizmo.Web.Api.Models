#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product stock.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductStock : IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The amount of stock.
        /// </summary>
        [Key(1)]
        public decimal? OnHand { get; set; }

        #endregion
    }
}