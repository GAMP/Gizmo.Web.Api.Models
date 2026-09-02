using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class VerificationCodeModel : IVerificationCodeModel
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(1)]
        public string? Recipient { get; init; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime Time { get; init; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(3)]
        public string? Code { get; init; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(4)]
        public VerificationCodeStatus Status { get; init; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(5)]
        public TokenType Type { get; init; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(6)]
        public int? UserId { get; init; }
    }
}
