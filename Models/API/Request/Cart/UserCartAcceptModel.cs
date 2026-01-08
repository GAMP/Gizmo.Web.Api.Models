using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User cart accept model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserCartAcceptModel : IWebApiModel
    {
        /// <summary>
        /// Optional note.
        /// </summary>
        [MessagePack.Key(0)]
        [StringLength(255)]
        public string? Note { get; init; }
    }
}
