using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application application group.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationApplicationGroupModel : IApplicationApplicationGroupModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the application group the application belongs to.
        /// </summary>
        [Key(0)]
        public int ApplicationGroupId { get; set; }

        #endregion
    }
}
