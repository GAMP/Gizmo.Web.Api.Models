using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Products available to a user group.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserGroupProductAvailabilityModel
    {
        #region PROPERTIES

        /// <summary>
        /// The ids of the products available to the user group.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<int> ProductIds { get; set; } = Enumerable.Empty<int>();

        #endregion
    }
}
