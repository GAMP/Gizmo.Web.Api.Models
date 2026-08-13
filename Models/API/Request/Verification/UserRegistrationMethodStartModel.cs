using System.ComponentModel.DataAnnotations;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User-facing registration method start request.
    /// </summary>
    [MessagePackObject]
    public sealed class UserRegistrationMethodStartModel
    {
        /// <summary>
        /// Verification method entry id.
        /// </summary>
        [Range(1, int.MaxValue)]
        [MessagePack.Key(0)]
        public required int MethodId { get; set; }

        /// <summary>
        /// Channel-specific destination value. Omitted for redirect methods.
        /// </summary>
        [MessagePack.Key(1)]
        public string? Value { get; set; }
    }
}
