using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when listing integrations.
    /// </summary>
    [MessagePackObject]
    public sealed class IntegrationsFilter : IWebApiModel, IModelFilter<IntegrationModel>
    {
        /// <summary>
        /// Pagination parameters.
        /// </summary>
        [Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Filter by integration type guid.
        /// Returns only integrations whose plugin type matches the specified guid.
        /// </summary>
        [Key(2)]
        public Guid? TypeGuid { get; set; }

        /// <summary>
        /// Filter by disabled state.
        /// </summary>
        [Key(3)]
        public bool? IsDisabled { get; set; }
    }
}
