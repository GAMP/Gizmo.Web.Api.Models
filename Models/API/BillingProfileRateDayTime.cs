using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Billing profile rate day time.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class BillingProfileRateDayTime
    {
        #region PROPERTIES

        /// <summary>
        /// The start second of this timespan.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(0)]
        public int StartSecond { get; set; }

        /// <summary>
        /// The end second of this timespan.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(1)]
        public int EndSecond { get; set; }

        #endregion
    }
}