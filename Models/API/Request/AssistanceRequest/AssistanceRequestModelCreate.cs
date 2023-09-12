using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Assistance request create.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class AssistanceRequestModelCreate : IUriParametersQuery
    {
        /// <summary>
        /// Request type id.
        /// </summary>
        [Required()]
        [MessagePack.Key(0)]
        public int AssistanceRequestTypeId { get; set; }

        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(1)]
        public int? UserId { get; set; }

        /// <summary>
        /// Host id.
        /// </summary>
        [Required()]
        [MessagePack.Key(2)]
        public int HostId { get;set; }

        /// <summary>
        /// Note.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(3)]
        public string? Note { get; set; }
    }
}
