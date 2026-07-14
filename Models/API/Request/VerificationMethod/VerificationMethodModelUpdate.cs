using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Verification method update model.
    /// </summary>
    /// <remarks>
    /// The integration reference, capability and context are immutable — they form the entry identity;
    /// to change the mechanism remove the entry and create a new one.
    /// </remarks>
    [MessagePack.MessagePackObject]
    public sealed class VerificationMethodModelUpdate : IWebApiModel
    {
        /// <summary>
        /// Optional custom display name shown to end users.
        /// </summary>
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string? CustomName { get; init; }

        /// <summary>
        /// Indicates the entry is offered on the initial method selection.
        /// </summary>
        [MessagePack.Key(1)]
        public bool IsPrimary { get; init; }

        /// <summary>
        /// Indicates whether the entry is disabled.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsDisabled { get; init; }

        /// <summary>
        /// Display order within the chain.
        /// </summary>
        [MessagePack.Key(3)]
        public int DisplayOrder { get; init; }
    }
}
