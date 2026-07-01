using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User logout flags.
    /// </summary>
    [Flags()]
    public enum UserLogoutFlags
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Suppress logout action.
        /// </summary>
        SuppressLogoutAction = 1,
    }
}
