using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Assistance request create.
    /// </summary>
    public sealed class AssistanceRequestModelCreate : IUriParametersQuery
    {
        /// <summary>
        /// Request type id.
        /// </summary>
        [Required()]
        public int AssistanceRequestTypeId { get; set; }

        /// <summary>
        /// User id.
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Host id.
        /// </summary>
        [Required()]
        public int HostId { get;set; }

        /// <summary>
        /// Note.
        /// </summary>
        [StringLength(255)]
        public string? Note { get; set; }
    }
}
