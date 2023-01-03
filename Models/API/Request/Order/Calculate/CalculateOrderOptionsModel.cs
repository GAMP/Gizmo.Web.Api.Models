#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Calculate order options.
    /// </summary>
    [MessagePackObject]
    public sealed class CalculateOrderOptionsModel : ICalculateOrderOptionsApiModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The lines of the order.
        /// </summary>
        [Key(0)]
        public IEnumerable<CalculateOrderLineOptions>? OrderLines { get; set; }

        #endregion
    }
}