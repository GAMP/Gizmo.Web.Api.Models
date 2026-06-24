using System;

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for public (user-facing) user agreements.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class PublicUserAgreementsFilter : IModelFilterPagination
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        #endregion
    }
}
