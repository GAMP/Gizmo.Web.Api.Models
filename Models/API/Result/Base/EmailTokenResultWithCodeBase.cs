#nullable enable

using MessagePack;
using System;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base verification result for email.
    /// </summary>
    public abstract class EmailTokenResultWithCodeBase<TResultCode> : TokenResultWithCodeBase<TResultCode> where TResultCode : Enum
    {
        #region PROPERTIES

        /// <summary>
        /// Gets email address.
        /// </summary>
        [Key(3)]
        [JsonPropertyOrder(3)]
        public virtual string? Email
        {
            get; set;
        }

        #endregion
    }
}
