using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Companion create model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CompanionModelCreate : ICompanionModel
    {
        /// <inheritdoc/>
        [Required()]
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string Name { get; set; } = string.Empty;
    }
}
