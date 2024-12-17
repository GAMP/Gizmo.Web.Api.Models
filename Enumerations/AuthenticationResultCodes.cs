using System.ComponentModel.DataAnnotations;

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
        [Name("Success", "AUTHENTICATION_RESULT_SUCCESS_NAME")]
        [ExtendedDescription("Authentication successful", "AUTHENTICATION_RESULT_SUCCESS_DESCRIPTION")]
        Success = 0,

        /// <summary>
        /// Unauthorized.
        /// </summary>
        [Name("Unauthorized", "AUTHENTICATION_RESULT_UNAUTHORIZED_NAME")]
        [ExtendedDescription("Unauthorized", "AUTHENTICATION_RESULT_UNAUTHORIZED_DESCRIPTION")]
        Unauthorized = 1,

        /// <summary>
        /// Network error.
        /// </summary>
        [Name("Network error", "AUTHENTICATION_RESULT_NETWORK_ERROR_NAME")]
        [ExtendedDescription("Failed due to a network error", "AUTHENTICATION_RESULT_NETWORK_ERROR_DESCRIPTION")]
        NetworkError = 2,

        /// <summary>
        /// General error.
        /// </summary>
        [Name("Error", "AUTHENTICATION_RESULT_ERROR_NAME")]
        [ExtendedDescription("Failed due to a network error", "AUTHENTICATION_RESULT_ERROR_DESCRIPTION")]
        Error = 3,
    }
}
