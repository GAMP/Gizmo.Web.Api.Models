namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Authentication result codes.
    /// </summary>
    public enum AuthenticationResultCodes
    {
        /// <summary>
        /// Success.
        /// </summary>
        Success = 0,

        /// <summary>
        /// Unauthorized.
        /// </summary>
        Unauthorized = 1,

        /// <summary>
        /// Network error.
        /// </summary>
        NetworkError = 2,

        /// <summary>
        /// General error.
        /// </summary>
        Error = 3,
    }
}
