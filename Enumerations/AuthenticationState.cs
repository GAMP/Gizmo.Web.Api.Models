using System.ComponentModel.DataAnnotations;

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
        [Name("Valid", "AUTHENTICATION_STATE_VALID_NAME")]
        [ExtendedDescription("Authentication valid", "AUTHENTICATION_STATE_VALID_DESCRIPTION")]
        Valid = 0,

        /// <summary>
        /// No token is present.
        /// </summary>
        [Name("No token", "AUTHENTICATION_STATE_NO_TOKEN_NAME")]
        [ExtendedDescription("No token present for authentication", "AUTHENTICATION_STATE_NO_TOKEN_DESCRIPTION")]
        NoToken = 1,

        /// <summary>
        /// The token is invalid.
        /// </summary>
        [Name("Invalid", "AUTHENTICATION_STATE_INVALID_NAME")]
        [ExtendedDescription("Authentication state is invalid", "AUTHENTICATION_STATE_INVALID_DESCRIPTION")] 
        Invalid = 2,

        /// <summary>
        /// The user is unauthorized.
        /// </summary>
        [Name("Unauthorized", "AUTHENTICATION_STATE_UNAUTHORIZED_NAME")]
        [ExtendedDescription("Unauthorized", "AUTHENTICATION_STATE_UNAUTHORIZED_DESCRIPTION")]
        Unauthorized = 3,

        /// <summary>
        /// Network error.
        /// </summary>
        [Name("Network error", "AUTHENTICATION_STATE_NETWORK_ERROR_NAME")]
        [ExtendedDescription("Authentication failed due to an network error", "AUTHENTICATION_STATE_NETWORK_ERROR_DESCRIPTION")]
        NetworkError = 4,

        /// <summary>
        /// General error.
        /// </summary>
        [Name("Error", "AUTHENTICATION_STATE_ERROR_NAME")]
        [ExtendedDescription("Authentication failed due to an error", "AUTHENTICATION_STATE_ERROR_DESCRIPTION")]
        Error = 5,
    }
}
