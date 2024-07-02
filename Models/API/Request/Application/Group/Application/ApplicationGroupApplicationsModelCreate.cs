using MessagePack;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application group applications.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationGroupApplicationsModelCreate
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the application group.
        /// </summary>
        [MessagePack.Key(0)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The list of applications within the application group.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<ApplicationGroupApplicationModel> Applications { get; set; } = Enumerable.Empty<ApplicationGroupApplicationModel>();

        #endregion
    }
}
