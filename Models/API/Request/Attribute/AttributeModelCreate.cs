using Gizmo.Web.Api.Models.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Attribute.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class AttributeModelCreate : IAttributeModel, IUriParametersQuery
    {
        /// <summary>
        /// The name of the attribute.
        /// </summary>
        [MessagePack.Key(0)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The friendly name of the attribute.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(45)]
        public string? FriendlyName { get; set; }
    }
}
