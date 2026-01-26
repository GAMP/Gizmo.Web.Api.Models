using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application options.
    /// </summary>
    [Flags()]
    public enum AppOptionType
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Halt execution on any error.
        /// </summary>
        HaltOnError = 1,
    }
}
