using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Line fixed time.
    /// </summary>
    [Serializable]
    [DataContract]
    public class LineFixedTime
    {
        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        public FixedTimeQuantityType QuantityType { get; set; }
    }
}