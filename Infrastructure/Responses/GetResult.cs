using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Get result.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class GetResult<T>
    {
        #region PROPERTIES

        /// <summary>
        /// The value.
        /// </summary>
        [DataMember]
        [Key(0)]
        public T Value { get; set; }

        #endregion
    }
}
