namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Authentication state.
    /// </summary>
    public enum AuthenticationState
    {
        /// <summary>
        /// The token is valid.
        /// </summary>
        Valid = 0,

        /// <summary>
        /// No token is present.
        /// </summary>
        NoToken = 1,

        /// <summary>
        /// The token is invalid.
        /// </summary>
        Invalid = 2,

        /// <summary>
        /// The token is unauthorized.
        /// </summary>
        Unauthorized = 3,

        /// <summary>
        /// Network error.
        /// </summary>
        NetworkError = 4,

        /// <summary>
        /// General error.
        /// </summary>
        Error = 5,
    }
}
