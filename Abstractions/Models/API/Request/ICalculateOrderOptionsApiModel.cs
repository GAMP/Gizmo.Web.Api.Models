using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Calculate order options.
    /// </summary>
    public interface ICalculateOrderOptionsApiModel
    {
        /// <summary>
        /// The lines of the order.
        /// </summary>
        IEnumerable<CalculateOrderLineOptions> OrderLines { get; set; }
    }
}