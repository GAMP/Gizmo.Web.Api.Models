#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Calculate order options.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class OrderCalculateModelOptions : IOrderCalculateOptionsApiModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The lines of the order.
        /// </summary>
        [Key(0)]
        public IEnumerable<OrderLineModelOptions>? OrderLines { get; set; }

        #endregion
    }
}