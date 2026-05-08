using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filter for host status query.
    /// </summary>
    [MessagePackObject]
    public sealed class HostStatusFilter
    {
        /// <summary>
        /// Layout group id. If not specified the default layout of the default branch will be used.
        /// </summary>
        [Key(0)]
        public int? LayoutId { get; init; }
    }
}
