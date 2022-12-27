using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Application.Group.Application
{
    /// <summary>
    /// Application group application.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationGroupApplication : IApplicationGroupApplicationApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the application group.
        /// </summary>
        [MessagePack.Key(0)]
        public int ApplicationGroupId { get; set; }

        /// <summary>
        /// The Id of the application associated with this application group.
        /// </summary>
        [Required]
        [MessagePack.Key(1)]
        public int ApplicationId { get; set; }

        #endregion
    }
}
