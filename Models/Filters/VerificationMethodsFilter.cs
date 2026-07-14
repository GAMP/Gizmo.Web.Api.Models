using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when listing verification methods.
    /// </summary>
    [MessagePackObject]
    public sealed class VerificationMethodsFilter : IWebApiModel, IModelFilter<VerificationMethodModel>
    {
        /// <summary>
        /// Pagination parameters.
        /// </summary>
        [Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Filter by chain context.
        /// </summary>
        [Key(2)]
        public VerificationContext? Context { get; set; }

        /// <summary>
        /// Filter by referenced integration id.
        /// </summary>
        [Key(3)]
        public int? IntegrationId { get; set; }

        /// <summary>
        /// Filter by disabled state.
        /// </summary>
        [Key(4)]
        public bool? IsDisabled { get; set; }
    }
}
