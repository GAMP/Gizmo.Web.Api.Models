using MessagePack;
using System;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base class for token results.
    /// </summary>
    /// <typeparam name="T">Result type.</typeparam>
    /// <remarks>
    /// Provides means to return generated token value and enum code in <see cref="TokenResultWithCodeBase{T}.Result"/>.
    /// </remarks>
    public abstract class TokenResultWithCodeBase<T> where T : Enum
    {
        #region PROPERTIES

        /// <summary>
        /// Verification result code.
        /// </summary>
        [Key(0)]
        [JsonPropertyOrder(0)]
        public T Result
        {
            get; set;
        }

        /// <summary>
        /// Token value.
        /// </summary>
        [Key(1)]
        [JsonPropertyOrder(1)]
        public string Token
        {
            get; set;
        }

        /// <summary>
        /// Gets confirmation code length.
        /// </summary>
        [Key(2)]
        [JsonPropertyOrder(2)]
        public int CodeLength
        {
            get; init;
        } = 0;

        #endregion
    }
}
