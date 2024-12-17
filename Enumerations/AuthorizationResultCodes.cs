namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Authorization result codes.
    /// </summary>
    public enum AuthorizationResultCodes
    {
        /// <summary>
        /// Success.
        /// </summary>
        Success,
        /// <summary>
        /// Unauthorized.
        /// </summary>
        Unauthorized,
        /// <summary>
        /// Expired token.
        /// </summary>
        TokenExpired,
        /// <summary>
        /// Invalid instance id.
        /// </summary>
        InvalidId,
        /// <summary>
        /// Network error.
        /// </summary>
        NetworkError,
        /// <summary>
        /// General error.
        /// </summary>
        Error,
    }
}
