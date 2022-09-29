using MessagePack;
using System;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base model class suppoorting Enum code result.
    /// </summary>
    /// <typeparam name="T">Result type.</typeparam>
    public abstract class ResultCodeBase<T> where T : Enum
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

        #endregion
    }
}
