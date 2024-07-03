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
    public sealed class ApplicationGroupApplicationsModelUpdate
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int ApplicationGroupId { get; set; }

        /// <summary>
        /// The name of the application group.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The list of applications within the application group.
        /// </summary>
        [MessagePack.Key(2)]
        public IEnumerable<ApplicationGroupApplicationModel> Applications { get; set; } = Enumerable.Empty<ApplicationGroupApplicationModel>();

        #endregion
    }
}
