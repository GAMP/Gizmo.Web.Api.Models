#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application group application.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationGroupApplicationModelCreate : IApplicationGroupApplicationApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the application associated with this application group.
        /// </summary>
        [Key(0)]
        public int ApplicationId { get; set; }

        #endregion
    }
}
