using System;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Dispatched verification code model.
    /// </summary>
    public interface IVerificationCodeModel : IWebApiModel, IModelIntIdentifier
    {
        /// <summary>
        /// Phone number or email address the code was dispatched to.
        /// </summary>
        public string? Recipient { get; init; }

        /// <summary>
        /// Time the code was created.
        /// </summary>
        public DateTime Time { get; init; }

        /// <summary>
        /// Confirmation code.
        /// </summary>
        public string? Code { get; init; }

        /// <summary>
        /// Status.
        /// </summary>
        public VerificationCodeStatus Status { get; init; }

        /// <summary>
        /// Token type the code was issued for.
        /// </summary>
        public TokenType Type { get; init; }

        /// <summary>
        /// Associated user id, null for registration codes.
        /// </summary>
        public int? UserId { get; init; }
    }
}
