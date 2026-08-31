using System.ComponentModel.DataAnnotations;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User-facing password recovery method start request.
    /// </summary>
    [MessagePackObject]
    public sealed class UserPasswordRecoveryMethodStartModel
    {
        /// <summary>
        /// Verification method entry id.
        /// </summary>
        [Range(1, int.MaxValue)]
        [MessagePack.Key(0)]
        public required int MethodId { get; set; }

        /// <summary>
        /// Value identifying the account to recover.
        /// </summary>
        [Required()]
        [MessagePack.Key(1)]
        public required string Value { get; set; }

        /// <summary>
        /// What <see cref="Value"/> holds.
        /// </summary>
        [Range((int)VerificationMethodValueKind.MobilePhone, (int)VerificationMethodValueKind.Username)]
        [MessagePack.Key(2)]
        public required VerificationMethodValueKind ValueKind { get; set; }
    }
}
