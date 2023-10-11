using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for registers.
    /// </summary>
    [Serializable, MessagePack.MessagePackObject]
    public sealed class RegistersFilter : IModelFilter<RegisterModel>
    {
        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Operator id.
        /// </summary>
        /// <remarks>
        /// This value is used in conjunction with branch id.<br></br> It can help filter out registers that are accesible for the operator at specified branch.
        /// </remarks>
        [MessagePack.Key(2)]
        public int? OperatorId
        {
            get;init;
        }

        /// <summary>
        /// Branch id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? BranchId
        {
            get;init;
        }
    }
}
