using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product availability day time.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ProductAvailabilityDayTime
    {
        /// <summary>
        /// The start second of this time span.
        /// </summary>
        [DataMember]
        public int StartSecond { get; set; }

        /// <summary>
        /// The end second of this time span.
        /// </summary>
        [DataMember]
        public int EndSecond { get; set; }
    }
}
