using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Application.Group
{
    /// <summary>
    /// Application group.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationGroupModelCreate : IApplicationGroupApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the application group.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        #endregion
    }
}
