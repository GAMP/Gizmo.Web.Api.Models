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
    /// Provides means to return generated token value and enum code in <see cref="ResultCodeBase{T}.Result"/>.
    /// </remarks>
    public abstract class TokenResultWithCodeBase<T> : ResultCodeBase<T> where T : Enum
    {
        #region PROPERTIES

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
