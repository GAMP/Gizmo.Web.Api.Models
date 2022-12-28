using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.Availability
{
    /// <summary>
    /// Product availability day time.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductAvailabilityDayTime
    {
        #region PROPERTIES

        /// <summary>
        /// The start second of this timespan.
        /// </summary>
        [MessagePack.Key(0)]
        public int StartSecond { get; set; }

        /// <summary>
        /// The end second of this timespan.
        /// </summary>
        [MessagePack.Key(1)]
        public int EndSecond { get; set; }

        #endregion
    }
}