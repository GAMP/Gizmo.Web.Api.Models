using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Companion update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CompanionUpdateModel : ICompanionModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [Required()]
        [StringLength(45)]
        [MessagePack.Key(1)]
        public string Name { get; set; } = string.Empty;
    }
}
