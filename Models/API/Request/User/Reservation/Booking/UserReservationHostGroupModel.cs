using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host group (zone) of the club hosts that can be booked.
    /// </summary>
    [MessagePackObject]
    public sealed class UserReservationHostGroupModel : IWebApiModel
    {
        /// <summary>
        /// Host group id.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Host group name.
        /// </summary>
        [Key(1)]
        public string Name { get; init; } = string.Empty;
    }
}
