using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Client task activation types.
    /// </summary>
    [Flags()]
    public enum ClientTaskActivationType
    {
        /// <summary>
        /// Startup.
        /// </summary>
        Startup = 1,

        /// <summary>
        /// Shut down.
        /// </summary>
        Shutdown = 2,

        /// <summary>
        /// Login.
        /// </summary>
        Login = 4,

        /// <summary>
        /// Logout.
        /// </summary>
        Logout = 8
    }
}
