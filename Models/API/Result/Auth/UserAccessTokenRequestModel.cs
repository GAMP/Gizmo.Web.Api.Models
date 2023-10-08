using Gizmo.Web.Api.Models.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User access token request model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserAccessTokenRequestModel : IUriParametersQuery
    {
        /// <summary>
        /// Username.
        /// </summary>
        [MessagePack.Key(0)]
        [Required(AllowEmptyStrings = false)]
        public string Username
        {
            get; init;
        } = string.Empty;

        /// <summary>
        /// Password.
        /// </summary>
        [MessagePack.Key(1)]
        [Required(AllowEmptyStrings = false)]
        public string Password
        {
            get; init;
        } = string.Empty;
    }
}
