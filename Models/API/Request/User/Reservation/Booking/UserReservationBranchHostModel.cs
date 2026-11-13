using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host of a club that can be booked.
    /// </summary>
    [MessagePackObject]
    public sealed class UserReservationBranchHostModel : IWebApiModel
    {
        /// <summary>
        /// Host id.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Host number.
        /// </summary>
        [Key(1)]
        public int Number { get; init; }

        /// <summary>
        /// Host name.
        /// </summary>
        [Key(2)]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Host group id.
        /// </summary>
        [Key(3)]
        public int HostGroupId { get; init; }
    }
}
