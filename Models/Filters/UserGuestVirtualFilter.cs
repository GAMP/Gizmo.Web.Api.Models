using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Virtual user guest search filter model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserGuestVirtualFilter : IUriParametersQuery
    {
        /// <summary>
        /// Results limit.
        /// </summary>
        [MessagePack.Key(0)]
        public int? Limit { get; init; }

        /// <summary>
        /// Branch id to filter by.
        /// </summary>
        [MessagePack.Key(2)]
        public int? BranchId { get; set; }

        /// <summary>
        /// Search value.
        /// </summary>
        [MessagePack.Key(3)]
        public string? SearchValue { get; init; }
    }
}
