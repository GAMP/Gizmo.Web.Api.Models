using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Get result.
    /// </summary>
    [Serializable]
    [DataContract]
    public class GetResult<T>
    {
        #region PROPERTIES

        /// <summary>
        /// The value.
        /// </summary>
        [DataMember]
        public T Value { get; set; }

        #endregion
    }
}
