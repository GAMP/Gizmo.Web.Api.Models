using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for payment intents.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class PaymentIntentsFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// Return payment intents where the date greater than or equal to the specified date.
        /// </summary>
        [Key(200)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return payment intents where the date less than or equal to the specified date.
        /// </summary>
        [Key(201)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return payment intents with the specified state.
        /// </summary>
        [Key(202)]
        public PaymentIntentState? State { get; set; }

        /// <summary>
        /// Return payment intents of the specified user.
        /// </summary>
        [Key(203)]
        public int? UserId { get; set; }

        #endregion
    }
}
