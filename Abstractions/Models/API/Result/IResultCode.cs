using System;

namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Result
{
    /// <summary>
    /// Interface suppoorting Enum code result.
    /// </summary>
    /// <typeparam name="T">Result type.</typeparam>
    public interface IResultCode<T> where T : Enum
    {
        /// <summary>
        /// Verification result code.
        /// </summary>
        T Result { get; set; }
    }
}