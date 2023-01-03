using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Verification result for email.
    /// </summary>
    public interface IEmailTokenResultWithCode<TResultCode> : ITokenResultWithCode<TResultCode> where TResultCode : Enum
    {
        /// <summary>
        /// Gets email address.
        /// </summary>
        string Email { get; set; }
    }
}