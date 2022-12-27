using System;

namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Result
{
    /// <summary>
    /// Interface for token results.
    /// </summary>
    /// <typeparam name="TResultCode">Result type.</typeparam>
    /// <remarks>
    /// Provides means to return generated token value and enum code in <see cref="IResultCode{T}.Result"/>.
    /// </remarks>
    public interface ITokenResultWithCode<TResultCode> : IResultCode<TResultCode> where TResultCode : Enum
    {
        /// <summary>
        /// Token value.
        /// </summary>
        string Token { get; set; }
        
        /// <summary>
        /// Gets confirmation code length.
        /// </summary>
        int CodeLength { get; init; }
    }
}