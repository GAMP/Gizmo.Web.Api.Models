using Gizmo.Web.Api.Models.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Access token request model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AccessTokenRequestModel : IUriParametersQuery
    {
        /// <summary>
        /// Username.
        /// </summary>
        [MessagePack.Key(0)]
        [Required(AllowEmptyStrings = false)]
        public string Username
        {
            get; init;
        } =string.Empty;

        /// <summary>
        /// Password.
        /// </summary>
        [MessagePack.Key(1)]
        [Required(AllowEmptyStrings = false)]
        public string Password
        {
            get; init;
        } = string.Empty;

        /// <summary>
        /// Branch id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? BranchId
        {
            get; init;
        }

        /// <summary>
        /// Register id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? RegisterId
        {
            get;init;
        }
    }
}
