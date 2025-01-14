using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Task model interface.
    /// </summary>
    public interface ITaskModel
    {
        /// <summary>
        /// Task name.
        /// </summary>
        public string Name { get; init; }

        /// <summary>
        /// Task guid.
        /// </summary>
        public Guid Guid { get; init; }
    }
}
