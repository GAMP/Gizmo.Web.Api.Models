using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{    /// <summary>
     /// User search filter model.
     /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserSearchFilter : IModelFilter<UserSearchResultModel>
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Search value to filter users by.<br></br>
        /// </summary>
        [MessagePack.Key(2)]
        [Required()]
        public string SearchValue { get; set; } = null!;
    }
}
