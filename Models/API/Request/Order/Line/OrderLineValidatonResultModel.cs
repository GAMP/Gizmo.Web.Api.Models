using System;
using Gizmo.Web.Api.Models.Abstractions;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models.Models
{
    /// <summary>
    /// Order line validation result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderLineValidatonResultModel
    {
        /// <summary>
        /// Line guid.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid? Guid { get; init; }

        /// <summary>
        /// Validation result.
        /// </summary>
        [MessagePack.Key(1)]
        public OrderLineValidatonResult Result
        {
            get; init;
        }

        /// <summary>
        /// Creates new result.
        /// </summary>
        /// <param name="model">Model.</param>
        /// <param name="result">Result.</param>
        /// <returns>New result model.</returns>
        public static OrderLineValidatonResultModel Create(IOrderLineCreateModel model, OrderLineValidatonResult result)
        {
            return new OrderLineValidatonResultModel() { Guid = model.Guid, Result = result };
        }
    }
}
