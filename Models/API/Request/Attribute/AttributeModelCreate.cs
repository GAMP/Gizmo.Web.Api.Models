using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Attribute.
    /// </summary>
    [MessagePackObject]
    public sealed class AttributeModelCreate : IAttributeApiModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the attribute.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// The friendly name of the attribute.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(45)]
        public string FriendlyName { get; set; }

        #endregion
    }
}