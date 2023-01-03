#nullable enable

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Billing profile rate day time.
    /// </summary>
    [MessagePackObject]
    public sealed class BillingProfileRateDayTime
    {
        #region PROPERTIES

        /// <summary>
        /// The start second of this timespan.
        /// </summary>
        [Key(0)]
        public int StartSecond { get; set; }

        /// <summary>
        /// The end second of this timespan.
        /// </summary>
        [Key(1)]
        public int EndSecond { get; set; }

        #endregion
    }
}