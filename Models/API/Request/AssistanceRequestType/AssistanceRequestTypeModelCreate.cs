using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Assitance request type create model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AssistanceRequestTypeModelCreate : IUriParametersQuery
    {
        /// <summary>
        /// Title.
        /// </summary>
        [MessagePack.Key(0)]
        [StringLength(45)]
        [Required()]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Display order.
        /// </summary>
        [MessagePack.Key(1)]
        public int DisplayOrder { get; set; }
    }
}
