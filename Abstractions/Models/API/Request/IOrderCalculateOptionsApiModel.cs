using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Calculate order options.
    /// </summary>
    public interface IOrderCalculateOptionsApiModel : IWebApiClientModel
    {
        /// <summary>
        /// The lines of the order.
        /// </summary>
        IEnumerable<OrderLineModelOptions> OrderLines { get; set; }
    }
}