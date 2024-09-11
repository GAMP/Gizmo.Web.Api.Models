using MessagePack;

using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application application groups.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationApplicationGroupsModelUpdate
    {
        #region PROPERTIES

        /// <summary>
        /// The list of application groups the application belongs to.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<ApplicationApplicationGroupModel> ApplicationGroups { get; set; } = Enumerable.Empty<ApplicationApplicationGroupModel>();

        #endregion
    }
}
