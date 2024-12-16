using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Authentication parameters.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AuthenticationParametersModel : IWebApiModel
    {
        /// <summary>
        /// Authentication username.
        /// </summary>
        [Required()]
        [MessagePack.Key(0)]
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Authentication password.
        /// </summary>
        [Required()]
        [MessagePack.Key(1)]
        public string Password { get; set; } = string.Empty;
    }
}
