using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Application.Group
{
    /// <summary>
    /// Application group.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationGroupModelUpdate : IApplicationGroupApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// The name of the application group.
        /// </summary>
        [MessagePack.Key(1)]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        #endregion
    }
}
