using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User unban model.
    /// </summary>
    public sealed class UserUnbanModel : IWebApiModel
    {
        /// <summary>
        /// Optional ban reason id.
        /// </summary>
        [MessagePack.Key(0)]
        public int? BanReasonId { get; set; }

        /// <summary>
        /// Optional ban note.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(1)]
        public string? Note { get; init; }
    }
}
