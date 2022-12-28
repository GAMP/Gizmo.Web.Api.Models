using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Transaction.Point
{
    /// <summary>
    /// Point transaction creation model.
    /// </summary>
    [MessagePackObject]
    public sealed class PointTransactionModelCreate : IPointTransactionApiModel
    {
        #region PROPERTIES  

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [Key(0)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets transaction type.
        /// </summary>
        [Key(1)]
        public PointsTransactionType Type { get; set; }

        /// <summary>
        /// Gets or sets amount.
        /// </summary>
        [Key(2)]
        public int Amount { get; set; }

        #endregion
    }
}
