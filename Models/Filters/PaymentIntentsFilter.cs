#nullable enable

using Gizmo.Web.Api.Models.Abstractions.Models.Filters;

using MessagePack;
using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for payment intents.
    /// </summary>
    [MessagePackObject]
    public class PaymentIntentsFilter : IFilterApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public PaginationFilter PaginationFilter { get; set; } = new();

        /// <summary>
        /// Return payment intents where the date greater than or equal to the specified date.
        /// </summary>
        [Key(1)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return payment intents where the date less than or equal to the specified date.
        /// </summary>
        [Key(2)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return payment intents with the specified state.
        /// </summary>
        [Key(3)]
        public PaymentIntentState? State { get; set; }

        /// <summary>
        /// Return payment intents of the specified user.
        /// </summary>
        [Key(4)]
        public int? UserId { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [Key(5)]
        public List<string> Expand { get; set; } = new();

        #endregion
    }
}
