#nullable enable

using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base verification result for email.
    /// </summary>
    [MessagePackObject()]
    public abstract class EmailVerificationResultBase<TResultCode> : TokenResultWithCodeBase<TResultCode> where TResultCode : Enum
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="email">Email address.</param>
        public EmailVerificationResultBase(string email)
        {
            Email = email;
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets email address phone beign verified.
        /// </summary>
        /// <remarks>
        /// This value will always be set even in case of failure.
        /// </remarks>
        [Key(3)]
        public string Email
        {
            get; init;
        } 

        #endregion
    }
}
