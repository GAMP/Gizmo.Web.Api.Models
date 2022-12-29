using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Calculate order options.
    /// </summary>
    [MessagePackObject]
    public sealed class CalculateOrderOptions : ICalculateOrderOptionsApiModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the payment method that is preferred.
        /// </summary>
        [Key(0)]
        public int? PreferredPaymentMethodId { get; set; }

        /// <summary>
        /// The lines of the order.
        /// </summary>
        [Key(1)]
        public IEnumerable<CalculateOrderLineOptions> OrderLines { get; set; }

        #endregion
    }
}