using System.ComponentModel.DataAnnotations;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Password recovery methods request for a user identified by a typed value.
    /// </summary>
    [MessagePackObject]
    public sealed class GetRecoveryMethodsModel
    {
        /// <summary>
        /// Value identifying the account to recover.
        /// </summary>
        [Required()]
        [MessagePack.Key(0)]
        public required string Value { get; set; }

        /// <summary>
        /// What <see cref="Value"/> holds.
        /// </summary>
        [Range((int)VerificationMethodValueKind.MobilePhone, (int)VerificationMethodValueKind.Username)]
        [MessagePack.Key(1)]
        public required VerificationMethodValueKind ValueKind { get; set; }
    }
}
