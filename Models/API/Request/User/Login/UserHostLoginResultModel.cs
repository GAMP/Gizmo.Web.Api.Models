using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Result of the login of the current user on a host.
    /// </summary>
    [MessagePackObject]
    public sealed class UserHostLoginResultModel : IWebApiModel
    {
        /// <summary>
        /// Result.
        /// </summary>
        [Key(0)]
        public UserHostLoginResult Result { get; init; }

        /// <summary>
        /// Name of the branch of the host; set when the result is <see cref="UserHostLoginResult.Success"/>.
        /// </summary>
        [Key(1)]
        public string? BranchName { get; init; }

        /// <summary>
        /// Number of the host; set when the result is <see cref="UserHostLoginResult.Success"/>.
        /// </summary>
        [Key(2)]
        public int? HostNumber { get; init; }
    }
}
