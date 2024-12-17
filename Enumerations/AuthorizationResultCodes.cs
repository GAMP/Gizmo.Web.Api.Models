using System.ComponentModel.DataAnnotations;

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
        [Name("Success", "AUTHORIZATION_RESULT_SUCCESS_NAME")]
        [ExtendedDescription("Authentication successful", "AUTHORIZATION_RESULT_SUCCESS_DESCRIPTION")]
        Success,

        /// <summary>
        /// Unauthorized.
        /// </summary>
        [Name("Unauthorized", "AUTHORIZATION_RESULT_UNAUTHORIZED_NAME")]
        [ExtendedDescription("Unauthorized", "AUTHORIZATION_RESULT_UNAUTHORIZED_DESCRIPTION")]
        Unauthorized,
        
        /// <summary>
        /// Expired token.
        /// </summary>
        [Name("Token expired", "AUTHORIZATION_RESULT_TOKEN_EXPIRED_NAME")]
        [ExtendedDescription("Failed due to a expired token", "AUTHORIZATION_RESULT_TOKEN_EXPIRED_DESCRIPTION")]
        TokenExpired,
        
        /// <summary>
        /// Invalid instance id.
        /// </summary>
        [Name("Invalid id", "AUTHORIZATION_RESULT_INVALID_ID_NAME")]
        [ExtendedDescription("Failed due to an invalid instance id", "AUTHORIZATION_RESULT_INVALID_ID_DESCRIPTION")]
        InvalidId,
        
        /// <summary>
        /// Network error.
        /// </summary>
        [Name("Network error", "AUTHORIZATION_RESULT_NETWORK_ERROR_NAME")]
        [ExtendedDescription("Failed due to an network error", "AUTHORIZATION_RESULT_NETWORK_ERROR_DESCRIPTION")]
        NetworkError,
        
        /// <summary>
        /// General error.
        /// </summary>
        [Name("Error", "AUTHORIZATION_RESULT_ERROR_NAME")]
        [ExtendedDescription("Failed due to an error", "AUTHORIZATION_RESULT_ERROR_DESCRIPTION")]
        Error,
    }
}
