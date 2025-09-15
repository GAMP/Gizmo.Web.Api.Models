using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Cart entry fixed time addition model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CartEntryFixedTimeAddModel : IWebApiModel
    {
        /// <summary>
        /// Fixed time minutes.
        /// </summary>
        [MessagePack.Key(0)]
        public int Minutes { get; set; }

        /// <summary>
        /// Host group id.
        /// </summary>
        [MessagePack.Key(1)]
        public int HostGroupId { get; set; }

        /// <summary>
        /// Start date.
        /// </summary>
        /// <remarks>
        /// This value is required to calculate totals based on bill profile.
        /// </remarks>
        [MessagePack.Key(2)]
        public DateTime StartDate { get; set; }
    }
}
