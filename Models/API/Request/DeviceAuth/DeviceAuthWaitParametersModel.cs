using Gizmo.Web.Api.Models.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device activation wait request parameters.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class DeviceAuthWaitParametersModel : IUriParametersQuery
    {
        /// <summary>
        /// Session nonce.
        /// </summary>
        [MessagePack.Key(0)]
        [Required(AllowEmptyStrings = false)]
        public string Nonce { get; init; } = string.Empty;
    }
}
