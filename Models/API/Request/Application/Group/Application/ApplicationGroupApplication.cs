#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
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
        [Key(0)]
        public int ApplicationGroupId { get; set; }

        /// <summary>
        /// The Id of the application associated with this application group.
        /// </summary>
        [Key(1)]
        public int ApplicationId { get; set; }

        #endregion
    }
}
