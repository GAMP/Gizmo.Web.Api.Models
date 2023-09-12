using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Assistance request user creation model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AssistanceRequestModelUserCreate : IUriParametersQuery
    {
        /// <summary>
        /// Assistance request type id.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        public int AssistanceRequestTypeId { get; set; }

        /// <summary>
        /// Note.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(255)]
        public string? Note { get; set; }
    }
}
